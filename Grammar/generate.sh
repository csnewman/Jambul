echo "Removing old files"
rm -R ../Jambul/Parser/CSharp/Antlr
rm -R built
echo "Building grammar files"
java -cp antlr-4.6-complete.jar org.antlr.v4.Tool -Dlanguage=CSharp -package Jambul.Parser.CSharp.Antlr -o built CSharpLexer.g4
java -cp antlr-4.6-complete.jar org.antlr.v4.Tool -Dlanguage=CSharp -package Jambul.Parser.CSharp.Antlr -o built -no-listener CSharpPreprocessorParser.g4
java -cp antlr-4.6-complete.jar org.antlr.v4.Tool -Dlanguage=CSharp -package Jambul.Parser.CSharp.Antlr -o built -no-listener -visitor CSharpParser.g4
echo "Copying files"
cd built
mkdir -p ../../Jambul/Parser/CSharp/Antlr
cp *.cs ../../Jambul/Parser/CSharp/Antlr
cd ..
echo "Cleaning up"
rm -R built
echo "Done"
