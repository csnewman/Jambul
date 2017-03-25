using System;
using System.Collections.Generic;
using System.IO;
using Antlr4.Runtime;
using Jambul.CSharp.IR;
using Jambul.CSharp.Parser.Antlr.AutoGen;

namespace Jambul.CSharp.Parser.Antlr
{
    public class CSharpAntlrParser
    {

        private CSharpParser.Compilation_unitContext ParseFile(string file)
        {
            IList<IToken> codeTokens = new List<IToken>();

            string sourceCode = File.ReadAllText(file);

            Lexer preprocessorLexer = new CSharpLexer(new AntlrInputStream(sourceCode));
            IList<IToken> tokens = preprocessorLexer.GetAllTokens();
            IList<IToken> directiveTokens = new List<IToken>();
            ListTokenSource directiveTokenSource = new ListTokenSource(directiveTokens);
            CommonTokenStream directiveTokenStream = new CommonTokenStream(directiveTokenSource, CSharpLexer.DIRECTIVE);
            CSharpPreprocessorParser preprocessorParser = new CSharpPreprocessorParser(directiveTokenStream);

            int index = 0;
            bool compiliedTokens = true;
            while (index < tokens.Count)
            {
                IToken token = tokens[index];
                if (token.Type == CSharpLexer.SHARP)
                {
                    directiveTokens.Clear();
                    int directiveTokenIndex = index + 1;
                    while (directiveTokenIndex < tokens.Count &&
                           tokens[directiveTokenIndex].Type != CSharpLexer.Eof &&
                           tokens[directiveTokenIndex].Type != CSharpLexer.DIRECTIVE_NEW_LINE &&
                           tokens[directiveTokenIndex].Type != CSharpLexer.SHARP)
                    {
                        if (tokens[directiveTokenIndex].Channel != Lexer.Hidden &&
                            tokens[directiveTokenIndex].Channel != CSharpLexer.COMMENTS_CHANNEL)
                        {
                            directiveTokens.Add(tokens[directiveTokenIndex]);
                        }
                        directiveTokenIndex++;
                    }
                    directiveTokenSource = new ListTokenSource(directiveTokens);
                    directiveTokenStream = new CommonTokenStream(directiveTokenSource, CSharpLexer.DIRECTIVE);
                    preprocessorParser.TokenStream = directiveTokenStream;

                    CSharpPreprocessorParser.Preprocessor_directiveContext directive =
                        preprocessorParser.preprocessor_directive();
                    // if true than next code is valid and not ignored.
                    compiliedTokens = directive.value;
                    index = directiveTokenIndex - 1;
                }
                else if (token.Channel != Lexer.Hidden && token.Type != CSharpLexer.DIRECTIVE_NEW_LINE &&
                         token.Channel != CSharpLexer.COMMENTS_CHANNEL &&
                         compiliedTokens)
                {
                    codeTokens.Add(token); // Collect code tokens.
                }
                index++;
            }

            ListTokenSource codeTokenSource = new ListTokenSource(codeTokens);
            CommonTokenStream codeTokenStream = new CommonTokenStream(codeTokenSource);
            CSharpParser parser = new CSharpParser(codeTokenStream);

            return parser.compilation_unit();
        }

        public void Parse(string fileName)
        {
            CSharpParser.Compilation_unitContext compilationUnit = ParseFile(fileName);

            if (compilationUnit.extern_alias_directives() != null)
                throw new NotSupportedException("Extern alias not supported");

            if (compilationUnit.global_attribute_section().Length > 0)
                throw new NotImplementedException("Global attributes are not implemented yet");

            IUsingStatement[] @using = compilationUnit.using_directives() != null
                ? compilationUnit.using_directives().Parse()
                : new IUsingStatement[0];

            Console.WriteLine("Using: " + string.Join<IUsingStatement>(", ", @using));

            NamespaceContext @namespace = new NamespaceContext(null, @using);

            if (compilationUnit.namespace_member_declarations() != null)
            {
                compilationUnit.namespace_member_declarations().Parse(@namespace);
            }

            Console.WriteLine("Done");
        }

    }
}
