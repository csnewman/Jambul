using System;
using System.Collections.Generic;
using System.Linq;
using Antlr4.Runtime.Tree;
using Jambul.CSharp.IR;
using Jambul.CSharp.Parser.Antlr.AutoGen;

namespace Jambul.CSharp.Parser.Antlr
{
    public static class TypeDeclarationExtensions
    {
        public static void Parse(this CSharpParser.Type_declarationContext context)
        {
            if (context.attributes() != null)
                throw new NotImplementedException("Attributes are not implemented yet");
            Modifiers modifiers = context.all_member_modifiers().Parse();

            if (context.class_definition() != null)
                context.class_definition().Parse();
            else
                throw new NotImplementedException("Non class types not implemented yet");


            Console.WriteLine("Modifiers " + modifiers);
        }

        public static void Parse(this CSharpParser.Class_definitionContext context)
        {
            Console.WriteLine("  " + context.identifier().GetText());

            if (context.type_parameter_list() != null)
                throw new NotImplementedException("Type parameters not implemented yet");
            if (context.class_base() != null)
                throw new NotImplementedException("Base class not supported yet");
            if (context.type_parameter_constraints_clauses() != null)
                throw new NotImplementedException("Type parameter contrainsts not implemented yet");

            CSharpParser.Class_bodyContext cbody = context.class_body();
            if (cbody.class_member_declarations() != null)
            {
                foreach (
                    CSharpParser.Class_member_declarationContext declarationContext in
                    cbody.class_member_declarations().class_member_declaration())
                {
                    declarationContext.Parse();
                }
            }
        }

        public static void Parse(this CSharpParser.Class_member_declarationContext context)
        {
            if (context.attributes() != null)
                throw new NotImplementedException("Attributes not implemented yet");

            Modifiers modifiers = context.all_member_modifiers() != null ? context.all_member_modifiers().Parse() : 0;
            Console.WriteLine("Modifiers " + modifiers);

            if (context.destructor_definition() != null)
                throw new NotImplementedException("Destructors not implemented yet");
            else if (context.common_member_declaration() != null)
                context.common_member_declaration().Parse();
            else
                throw new NotSupportedException("Unknown member type");
        }

        public static void Parse(this CSharpParser.Common_member_declarationContext context)
        {
            if (context.constant_declaration() != null)
                throw new NotImplementedException("Constant declarations not implemented yet");
            else if (context.typed_member_declaration() != null)
                throw new NotImplementedException("Typed memeber declaration not implemented yet");
            else if (context.event_declaration() != null)
                throw new NotImplementedException("Event declaration not implemented yet");
            else if (context.conversion_operator_declarator() != null)
                throw new NotImplementedException("Conversion operator declaration not implemented yet");
            else if (context.constructor_declaration() != null)
                throw new NotImplementedException("Constructor declaration not implemented yet");
            else if (context.method_declaration() != null)
                context.method_declaration().Parse();
            else if (context.class_definition() != null)
                throw new NotImplementedException("Child class declaration not implemented yet");
            else if (context.struct_definition() != null)
                throw new NotImplementedException("Child struct declaration not implemented yet");
            else if (context.interface_definition() != null)
                throw new NotImplementedException("Child interface declaration not implemented yet");
            else if (context.enum_definition() != null)
                throw new NotImplementedException("Enum declaration not implemented yet");
            else if (context.delegate_definition() != null)
                throw new NotImplementedException("Delegate declaration not implemented yet");
            else
                throw new NotSupportedException("Unknown common member");
        }

        public static void Parse(this CSharpParser.Method_declarationContext context)
        {
            context.method_member_name().Parse();
        }

        public static MethodName Parse(this CSharpParser.Method_member_nameContext context)
        {
            IParseTree[] children = context.children.ToArray();
            IList<MethodName.Component> components = new List<MethodName.Component>();

            int i = 0;

            string nsAlias = null;

            if (children.Length > 1 && children[1] is TerminalNodeImpl &&
                ((TerminalNodeImpl) children[1]).IsType(CSharpLexer.DOUBLE_COLON))
            {
                if (!(children[0] is CSharpParser.IdentifierContext))
                    throw new ArgumentException("Expected identifier first in alias");

                nsAlias = ((CSharpParser.IdentifierContext) children[0]).ParseAsText();
                i += 2;
            }

            while (i < children.Length - 1)
            {
                IParseTree child = children[i];

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

                if (
                    !(i < children.Length && children[i] is TerminalNodeImpl &&
                      ((TerminalNodeImpl) children[i]).IsType(CSharpLexer.DOT)))
                    throw new ArgumentException("Expected dot next!");
                i++;

                components.Add(new MethodName.Component(name, typeArguments));
            }

            if (i != children.Length - 1)
                throw new ArgumentException("Child parsing skipped child!");

            IParseTree lastChild = children[i];

            if (!(lastChild is CSharpParser.IdentifierContext))
                throw new ArgumentException("Expected identifier last");

            string methodName = ((CSharpParser.IdentifierContext)lastChild).ParseAsText();


            return new MethodName(methodName, nsAlias, components.ToArray());
        }
    }
}