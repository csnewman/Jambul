using Antlr4.Runtime.Tree;
using Jambul.CSharp.Parser.Antlr.AutoGen;

namespace Jambul.CSharp.Parser.Antlr
{
    public static class MiscExtensions
    {
        public static int GetType(this TerminalNodeImpl node)
        {
            return node.Symbol.Type;
        }

        public static bool IsType(this TerminalNodeImpl node, int type)
        {
            return node.Symbol.Type == type;
        }

        public static string ParseAsText(this CSharpParser.IdentifierContext context)
        {
            return context.GetText();
        }
    }
}