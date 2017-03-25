using System;
using System.Linq;
using Jambul.CSharp.IR;
using Jambul.CSharp.Parser.Antlr.AutoGen;

namespace Jambul.CSharp.Parser.Antlr
{
    public static class ModifierExtensions
    {
        public static Modifiers Parse(this CSharpParser.All_member_modifiersContext context)
        {
            return context.all_member_modifier()
                .Aggregate<CSharpParser.All_member_modifierContext, Modifiers>(0,
                    (current, modifierContext) => current | Parse((CSharpParser.All_member_modifierContext) modifierContext));
        }

        public static Modifiers Parse(this CSharpParser.All_member_modifierContext context)
        {
            if (context.NEW() != null)
                return Modifiers.New;
            else if (context.PUBLIC() != null)
                return Modifiers.Public;
            else if (context.PROTECTED() != null)
                return Modifiers.Protected;
            else if (context.INTERNAL() != null)
                return Modifiers.Internal;
            else if (context.PRIVATE() != null)
                return Modifiers.Private;
            else if (context.READONLY() != null)
                return Modifiers.ReadOnly;
            else if (context.VOLATILE() != null)
                return Modifiers.Volatile;
            else if (context.VIRTUAL() != null)
                return Modifiers.Virtual;
            else if (context.SEALED() != null)
                return Modifiers.Sealed;
            else if (context.OVERRIDE() != null)
                return Modifiers.Override;
            else if (context.ABSTRACT() != null)
                return Modifiers.Abstract;
            else if (context.STATIC() != null)
                return Modifiers.Static;
            else if (context.UNSAFE() != null)
                return Modifiers.Unsafe;
            else if (context.EXTERN() != null)
                return Modifiers.Extern;
            else if (context.PARTIAL() != null)
                return Modifiers.Partial;
            else if (context.ASYNC() != null)
                return Modifiers.Async;
            throw new NotSupportedException("Unknown modifier " + context.GetText());
        }
    }
}