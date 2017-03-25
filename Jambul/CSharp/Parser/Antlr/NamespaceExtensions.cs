using System;
using System.Linq;
using Jambul.CSharp.IR;
using Jambul.CSharp.Parser.Antlr.AutoGen;

namespace Jambul.CSharp.Parser.Antlr
{
    public static class NamespaceExtensions
    {
        public static string ParseAsNamespace(this CSharpParser.Namespace_or_type_nameContext context)
        {
            if (context.type_argument_list().Length > 0)
                throw new NotSupportedException("Type arguments not supported on namespace names");
            if (context.qualified_alias_member() != null)
                throw new NotSupportedException("Qualified alias not supported on namespace names");
            return context.GetText();
        }

        public static IUsingStatement[] Parse(this CSharpParser.Using_directivesContext context)
        {
            return context.using_directive().Select(c => c.Parse()).ToArray();
        }

        public static IUsingStatement Parse(this CSharpParser.Using_directiveContext context)
        {
            if (context is CSharpParser.UsingAliasDirectiveContext)
                throw new NotImplementedException("Alias using statements not implemented yet");
            else if (context is CSharpParser.UsingNamespaceDirectiveContext)
                return
                    new UsingNamespace(
                        ((CSharpParser.UsingNamespaceDirectiveContext) context).namespace_or_type_name()
                        .ParseAsNamespace());
            else if (context is CSharpParser.UsingStaticDirectiveContext)
                throw new NotImplementedException("Static using statements not implemented yet");
            else
                throw new NotSupportedException("Unknown using type! " + context.GetText());
        }

        public static void Parse(this CSharpParser.Namespace_member_declarationsContext context, NamespaceContext ns)
        {
            foreach (
                CSharpParser.Namespace_member_declarationContext declarationContext in
                context.namespace_member_declaration())
                declarationContext.Parse(ns);
        }

        public static void Parse(this CSharpParser.Namespace_member_declarationContext context, NamespaceContext ns)
        {
            if (context.namespace_declaration() != null)
                context.namespace_declaration().Parse(ns);
            else if (context.type_declaration() != null)
                context.type_declaration().Parse();
            else
                throw new NotSupportedException("Unknown member type! " + context.GetText());
        }

        public static void Parse(this CSharpParser.Namespace_declarationContext context, NamespaceContext ns)
        {
            context.namespace_body().Parse(ns, context.qualified_identifier().GetText());
        }

        public static void Parse(this CSharpParser.Namespace_bodyContext context, NamespaceContext parent, string name)
        {
            if (context.extern_alias_directives() != null)
                throw new NotSupportedException("Extern alias not supported");

            IUsingStatement[] @using = context.using_directives() != null
                ? context.using_directives().Parse()
                : new IUsingStatement[0];

            NamespaceContext ns = parent.GetChildContext(name, @using);

            if (context.namespace_member_declarations() != null)
                context.namespace_member_declarations().Parse(ns);
        }
    }
}