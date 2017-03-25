using System;
using Jambul.CSharp.Parser.Antlr;

namespace Jambul
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CSharpAntlrParser converter = new CSharpAntlrParser();
            converter.Parse("../../../Tests/Program.cs");

            Console.ReadKey();
        }
    }
}