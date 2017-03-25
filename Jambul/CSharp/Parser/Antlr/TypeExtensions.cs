using System;
using System.Collections.Generic;
using System.Linq;
using Antlr4.Runtime.Tree;
using Jambul.CSharp.IR;
using Jambul.CSharp.Parser.Antlr.AutoGen;

namespace Jambul.CSharp.Parser.Antlr
{
    public static class TypeExtensions
    {
        public static IType[] Parse(this CSharpParser.Type_argument_listContext context)
        {
            return context.type().Select(c => c.Parse()).ToArray();
        }

        public static IType Parse(this CSharpParser.TypeContext context)
        {
            IType currenType = context.base_type().Parse();

            IParseTree[] children = context.children.ToArray();
            for (int i = 1; i < children.Length; i++)
            {
                IParseTree child = children[i];

                if (child is TerminalNodeImpl)
                {
                    TerminalNodeImpl node = (TerminalNodeImpl) child;
                    if (node.IsType(CSharpLexer.INTERR))
                        currenType = new NullableType(currenType);
                    else if (node.IsType(CSharpLexer.STAR))
                        currenType = new PointerType(currenType);
                    else
                        throw new NotSupportedException("");
                }
                else if (child is CSharpParser.Rank_specifierContext)
                {
                    CSharpParser.Rank_specifierContext rank = (CSharpParser.Rank_specifierContext) child;
                    currenType = new ArrayType(currenType, rank.Parse());
                }
                else
                    throw new NotSupportedException("Unknown type " + child.GetText());
            }
            return currenType;
        }

        public static IType Parse(this CSharpParser.Base_typeContext context)
        {
            if (context.simple_type() != null)
                return context.simple_type().Parse();
            else if (context.class_type() != null)
                return context.class_type().Parse();
            else if (context.VOID() != null)
                return new InbuiltType(InbuiltType.Types.VoidPtr);
            else
                throw new NotSupportedException("Unknown base type " + context.GetText());
        }

        public static IType Parse(this CSharpParser.Simple_typeContext context)
        {
            if (context.numeric_type() != null)
                return context.numeric_type().Parse();
            else if (context.BOOL() != null)
                return new InbuiltType(InbuiltType.Types.Boolean);
            else
                throw new NotSupportedException("Unknown simple type " + context.GetText());
        }

        public static IType Parse(this CSharpParser.Numeric_typeContext context)
        {
            if (context.integral_type() != null)
                return context.integral_type().Parse();
            else if (context.floating_point_type() != null)
                return context.floating_point_type().Parse();
            else if (context.DECIMAL() != null)
                return new InbuiltType(InbuiltType.Types.Decimal);
            else
                throw new NotSupportedException("Unknown numeric type " + context.GetText());
        }

        public static IType Parse(this CSharpParser.Integral_typeContext context)
        {
            if (context.SBYTE() != null)
                return new InbuiltType(InbuiltType.Types.SByte);
            else if (context.BYTE() != null)
                return new InbuiltType(InbuiltType.Types.Byte);
            else if (context.SHORT() != null)
                return new InbuiltType(InbuiltType.Types.Short);
            else if (context.USHORT() != null)
                return new InbuiltType(InbuiltType.Types.UShort);
            else if (context.INT() != null)
                return new InbuiltType(InbuiltType.Types.Int);
            else if (context.UINT() != null)
                return new InbuiltType(InbuiltType.Types.UInt);
            else if (context.LONG() != null)
                return new InbuiltType(InbuiltType.Types.Long);
            else if (context.ULONG() != null)
                return new InbuiltType(InbuiltType.Types.ULong);
            else if (context.CHAR() != null)
                return new InbuiltType(InbuiltType.Types.Char);
            else
                throw new NotSupportedException("Unknown integral type " + context.GetText());
        }

        public static IType Parse(this CSharpParser.Floating_point_typeContext context)
        {
            if (context.FLOAT() != null)
                return new InbuiltType(InbuiltType.Types.Float);
            else if (context.DOUBLE() != null)
                return new InbuiltType(InbuiltType.Types.Double);
            else
                throw new NotSupportedException("Unknown floating point type " + context.GetText());
        }

        public static IType Parse(this CSharpParser.Class_typeContext context)
        {
            if (context.namespace_or_type_name() != null)
                return new NamedType(context.namespace_or_type_name().ParseAsType());
            else if (context.OBJECT() != null)
                return new InbuiltType(InbuiltType.Types.Object);
            else if (context.DYNAMIC() != null)
                return new InbuiltType(InbuiltType.Types.Dynamic);
            else if (context.STRING() != null)
                return new InbuiltType(InbuiltType.Types.String);
            else
                throw new NotSupportedException("Unknown class type " + context.GetText());
        }

        public static int Parse(this CSharpParser.Rank_specifierContext context)
        {
            return context.GetTokens(CSharpLexer.COMMA).Length + 1;
        }

        public static TypeName ParseAsType(this CSharpParser.Namespace_or_type_nameContext context)
        {
            IParseTree[] children = context.children.ToArray();
            IList<TypeName.Component> components = new List<TypeName.Component>();
            int i = 0;

            string nsAlias = null;
            if (children.Length > 0 && children[0] is CSharpParser.Qualified_alias_memberContext)
            {
                CSharpParser.Qualified_alias_memberContext qamc =
                    (CSharpParser.Qualified_alias_memberContext) children[0];
                nsAlias = qamc.identifier(0).ParseAsText();
                string name = qamc.identifier(1).ParseAsText();

                IType[] typeArguments = null;
                if (qamc.type_argument_list() != null)
                    typeArguments = qamc.type_argument_list().Parse();
                components.Add(new TypeName.Component(name, typeArguments));

                i++;
            }

            while (i < children.Length)
            {
                IParseTree child = children[i];

                if (child is TerminalNodeImpl &&
                    ((TerminalNodeImpl) children[i]).IsType(CSharpLexer.DOT)) continue;

                if (!(child is CSharpParser.IdentifierContext))
                    throw new ArgumentException("Expected identifier next");

                string name = ((CSharpParser.IdentifierContext) child).ParseAsText();
                i++;

                IType[] typeArguments = null;
                if (i < children.Length && children[i] is CSharpParser.Type_argument_listContext)
                {
                    typeArguments = ((CSharpParser.Type_argument_listContext) children[i]).Parse();
                    i++;
                }

                components.Add(new TypeName.Component(name, typeArguments));
            }

            return new TypeName(nsAlias, components.ToArray());
        }
    }
}