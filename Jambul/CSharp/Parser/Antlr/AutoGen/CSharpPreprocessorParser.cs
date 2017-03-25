//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from CSharpPreprocessorParser.g4 by ANTLR 4.6

// Unreachable code detected

using System.Collections.Generic;
using System.Linq;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;

#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Jambul.CSharp.Parser.Antlr.AutoGen {
    using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6")]
[System.CLSCompliant(false)]
public partial class CSharpPreprocessorParser : Antlr4.Runtime.Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		BYTE_ORDER_MARK=1, SINGLE_LINE_DOC_COMMENT=2, DELIMITED_DOC_COMMENT=3, 
		SINGLE_LINE_COMMENT=4, DELIMITED_COMMENT=5, WHITESPACES=6, SHARP=7, ABSTRACT=8, 
		ADD=9, ALIAS=10, ARGLIST=11, AS=12, ASCENDING=13, ASYNC=14, AWAIT=15, 
		BASE=16, BOOL=17, BREAK=18, BY=19, BYTE=20, CASE=21, CATCH=22, CHAR=23, 
		CHECKED=24, CLASS=25, CONST=26, CONTINUE=27, DECIMAL=28, DEFAULT=29, DELEGATE=30, 
		DESCENDING=31, DO=32, DOUBLE=33, DYNAMIC=34, ELSE=35, ENUM=36, EQUALS=37, 
		EVENT=38, EXPLICIT=39, EXTERN=40, FALSE=41, FINALLY=42, FIXED=43, FLOAT=44, 
		FOR=45, FOREACH=46, FROM=47, GET=48, GOTO=49, GROUP=50, IF=51, IMPLICIT=52, 
		IN=53, INT=54, INTERFACE=55, INTERNAL=56, INTO=57, IS=58, JOIN=59, LET=60, 
		LOCK=61, LONG=62, NAMEOF=63, NAMESPACE=64, NEW=65, NULL=66, OBJECT=67, 
		ON=68, OPERATOR=69, ORDERBY=70, OUT=71, OVERRIDE=72, PARAMS=73, PARTIAL=74, 
		PRIVATE=75, PROTECTED=76, PUBLIC=77, READONLY=78, REF=79, REMOVE=80, RETURN=81, 
		SBYTE=82, SEALED=83, SELECT=84, SET=85, SHORT=86, SIZEOF=87, STACKALLOC=88, 
		STATIC=89, STRING=90, STRUCT=91, SWITCH=92, THIS=93, THROW=94, TRUE=95, 
		TRY=96, TYPEOF=97, UINT=98, ULONG=99, UNCHECKED=100, UNSAFE=101, USHORT=102, 
		USING=103, VIRTUAL=104, VOID=105, VOLATILE=106, WHEN=107, WHERE=108, WHILE=109, 
		YIELD=110, IDENTIFIER=111, LITERAL_ACCESS=112, INTEGER_LITERAL=113, HEX_INTEGER_LITERAL=114, 
		REAL_LITERAL=115, CHARACTER_LITERAL=116, REGULAR_STRING=117, VERBATIUM_STRING=118, 
		INTERPOLATED_REGULAR_STRING_START=119, INTERPOLATED_VERBATIUM_STRING_START=120, 
		OPEN_BRACE=121, CLOSE_BRACE=122, OPEN_BRACKET=123, CLOSE_BRACKET=124, 
		OPEN_PARENS=125, CLOSE_PARENS=126, DOT=127, COMMA=128, COLON=129, SEMICOLON=130, 
		PLUS=131, MINUS=132, STAR=133, DIV=134, PERCENT=135, AMP=136, BITWISE_OR=137, 
		CARET=138, BANG=139, TILDE=140, ASSIGNMENT=141, LT=142, GT=143, INTERR=144, 
		DOUBLE_COLON=145, OP_COALESCING=146, OP_INC=147, OP_DEC=148, OP_AND=149, 
		OP_OR=150, OP_PTR=151, OP_EQ=152, OP_NE=153, OP_LE=154, OP_GE=155, OP_ADD_ASSIGNMENT=156, 
		OP_SUB_ASSIGNMENT=157, OP_MULT_ASSIGNMENT=158, OP_DIV_ASSIGNMENT=159, 
		OP_MOD_ASSIGNMENT=160, OP_AND_ASSIGNMENT=161, OP_OR_ASSIGNMENT=162, OP_XOR_ASSIGNMENT=163, 
		OP_LEFT_SHIFT=164, OP_LEFT_SHIFT_ASSIGNMENT=165, DOUBLE_CURLY_INSIDE=166, 
		OPEN_BRACE_INSIDE=167, REGULAR_CHAR_INSIDE=168, VERBATIUM_DOUBLE_QUOTE_INSIDE=169, 
		DOUBLE_QUOTE_INSIDE=170, REGULAR_STRING_INSIDE=171, VERBATIUM_INSIDE_STRING=172, 
		CLOSE_BRACE_INSIDE=173, FORMAT_STRING=174, DIRECTIVE_WHITESPACES=175, 
		DIGITS=176, DEFINE=177, UNDEF=178, ELIF=179, ENDIF=180, LINE=181, ERROR=182, 
		WARNING=183, REGION=184, ENDREGION=185, PRAGMA=186, DIRECTIVE_HIDDEN=187, 
		CONDITIONAL_SYMBOL=188, DIRECTIVE_NEW_LINE=189, TEXT=190, DOUBLE_CURLY_CLOSE_INSIDE=191;
	public const int
		RULE_preprocessor_directive = 0, RULE_directive_new_line_or_sharp = 1, 
		RULE_preprocessor_expression = 2;
	public static readonly string[] ruleNames = {
		"preprocessor_directive", "directive_new_line_or_sharp", "preprocessor_expression"
	};

	private static readonly string[] _LiteralNames = {
		null, "'\\u00EF\\u00BB\\u00BF'", null, null, null, null, null, "'#'", 
		"'abstract'", "'add'", "'alias'", "'__arglist'", "'as'", "'ascending'", 
		"'async'", "'await'", "'base'", "'bool'", "'break'", "'by'", "'byte'", 
		"'case'", "'catch'", "'char'", "'checked'", "'class'", "'const'", "'continue'", 
		"'decimal'", "'default'", "'delegate'", "'descending'", "'do'", "'double'", 
		"'dynamic'", "'else'", "'enum'", "'equals'", "'event'", "'explicit'", 
		"'extern'", "'false'", "'finally'", "'fixed'", "'float'", "'for'", "'foreach'", 
		"'from'", "'get'", "'goto'", "'group'", "'if'", "'implicit'", "'in'", 
		"'int'", "'interface'", "'internal'", "'into'", "'is'", "'join'", "'let'", 
		"'lock'", "'long'", "'nameof'", "'namespace'", "'new'", "'null'", "'object'", 
		"'on'", "'operator'", "'orderby'", "'out'", "'override'", "'params'", 
		"'partial'", "'private'", "'protected'", "'public'", "'readonly'", "'ref'", 
		"'remove'", "'return'", "'sbyte'", "'sealed'", "'select'", "'set'", "'short'", 
		"'sizeof'", "'stackalloc'", "'static'", "'string'", "'struct'", "'switch'", 
		"'this'", "'throw'", "'true'", "'try'", "'typeof'", "'uint'", "'ulong'", 
		"'unchecked'", "'unsafe'", "'ushort'", "'using'", "'virtual'", "'void'", 
		"'volatile'", "'when'", "'where'", "'while'", "'yield'", null, null, null, 
		null, null, null, null, null, null, null, "'{'", "'}'", "'['", "']'", 
		"'('", "')'", "'.'", "','", "':'", "';'", "'+'", "'-'", "'*'", "'/'", 
		"'%'", "'&'", "'|'", "'^'", "'!'", "'~'", "'='", "'<'", "'>'", "'?'", 
		"'::'", "'??'", "'++'", "'--'", "'&&'", "'||'", "'->'", "'=='", "'!='", 
		"'<='", "'>='", "'+='", "'-='", "'*='", "'/='", "'%='", "'&='", "'|='", 
		"'^='", "'<<'", "'<<='", "'{{'", null, null, null, null, null, null, null, 
		null, null, null, "'define'", "'undef'", "'elif'", "'endif'", "'line'", 
		null, null, null, null, null, "'hidden'", null, null, null, "'}}'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "BYTE_ORDER_MARK", "SINGLE_LINE_DOC_COMMENT", "DELIMITED_DOC_COMMENT", 
		"SINGLE_LINE_COMMENT", "DELIMITED_COMMENT", "WHITESPACES", "SHARP", "ABSTRACT", 
		"ADD", "ALIAS", "ARGLIST", "AS", "ASCENDING", "ASYNC", "AWAIT", "BASE", 
		"BOOL", "BREAK", "BY", "BYTE", "CASE", "CATCH", "CHAR", "CHECKED", "CLASS", 
		"CONST", "CONTINUE", "DECIMAL", "DEFAULT", "DELEGATE", "DESCENDING", "DO", 
		"DOUBLE", "DYNAMIC", "ELSE", "ENUM", "EQUALS", "EVENT", "EXPLICIT", "EXTERN", 
		"FALSE", "FINALLY", "FIXED", "FLOAT", "FOR", "FOREACH", "FROM", "GET", 
		"GOTO", "GROUP", "IF", "IMPLICIT", "IN", "INT", "INTERFACE", "INTERNAL", 
		"INTO", "IS", "JOIN", "LET", "LOCK", "LONG", "NAMEOF", "NAMESPACE", "NEW", 
		"NULL", "OBJECT", "ON", "OPERATOR", "ORDERBY", "OUT", "OVERRIDE", "PARAMS", 
		"PARTIAL", "PRIVATE", "PROTECTED", "PUBLIC", "READONLY", "REF", "REMOVE", 
		"RETURN", "SBYTE", "SEALED", "SELECT", "SET", "SHORT", "SIZEOF", "STACKALLOC", 
		"STATIC", "STRING", "STRUCT", "SWITCH", "THIS", "THROW", "TRUE", "TRY", 
		"TYPEOF", "UINT", "ULONG", "UNCHECKED", "UNSAFE", "USHORT", "USING", "VIRTUAL", 
		"VOID", "VOLATILE", "WHEN", "WHERE", "WHILE", "YIELD", "IDENTIFIER", "LITERAL_ACCESS", 
		"INTEGER_LITERAL", "HEX_INTEGER_LITERAL", "REAL_LITERAL", "CHARACTER_LITERAL", 
		"REGULAR_STRING", "VERBATIUM_STRING", "INTERPOLATED_REGULAR_STRING_START", 
		"INTERPOLATED_VERBATIUM_STRING_START", "OPEN_BRACE", "CLOSE_BRACE", "OPEN_BRACKET", 
		"CLOSE_BRACKET", "OPEN_PARENS", "CLOSE_PARENS", "DOT", "COMMA", "COLON", 
		"SEMICOLON", "PLUS", "MINUS", "STAR", "DIV", "PERCENT", "AMP", "BITWISE_OR", 
		"CARET", "BANG", "TILDE", "ASSIGNMENT", "LT", "GT", "INTERR", "DOUBLE_COLON", 
		"OP_COALESCING", "OP_INC", "OP_DEC", "OP_AND", "OP_OR", "OP_PTR", "OP_EQ", 
		"OP_NE", "OP_LE", "OP_GE", "OP_ADD_ASSIGNMENT", "OP_SUB_ASSIGNMENT", "OP_MULT_ASSIGNMENT", 
		"OP_DIV_ASSIGNMENT", "OP_MOD_ASSIGNMENT", "OP_AND_ASSIGNMENT", "OP_OR_ASSIGNMENT", 
		"OP_XOR_ASSIGNMENT", "OP_LEFT_SHIFT", "OP_LEFT_SHIFT_ASSIGNMENT", "DOUBLE_CURLY_INSIDE", 
		"OPEN_BRACE_INSIDE", "REGULAR_CHAR_INSIDE", "VERBATIUM_DOUBLE_QUOTE_INSIDE", 
		"DOUBLE_QUOTE_INSIDE", "REGULAR_STRING_INSIDE", "VERBATIUM_INSIDE_STRING", 
		"CLOSE_BRACE_INSIDE", "FORMAT_STRING", "DIRECTIVE_WHITESPACES", "DIGITS", 
		"DEFINE", "UNDEF", "ELIF", "ENDIF", "LINE", "ERROR", "WARNING", "REGION", 
		"ENDREGION", "PRAGMA", "DIRECTIVE_HIDDEN", "CONDITIONAL_SYMBOL", "DIRECTIVE_NEW_LINE", 
		"TEXT", "DOUBLE_CURLY_CLOSE_INSIDE"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "CSharpPreprocessorParser.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	static CSharpPreprocessorParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

	Stack<bool> conditions = new Stack<bool>(new bool[] { true });
	public HashSet<string> ConditionalSymbols = new HashSet<string>() { "DEBUG" };
	public CSharpPreprocessorParser(ITokenStream input)
		: base(input)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}
	public partial class Preprocessor_directiveContext : ParserRuleContext {
		public bool value;
		public Preprocessor_directiveContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_preprocessor_directive; } }
	 
		public Preprocessor_directiveContext() { }
		public virtual void CopyFrom(Preprocessor_directiveContext context) {
			base.CopyFrom(context);
			this.value = context.value;
		}
	}
	public partial class PreprocessorDiagnosticContext : Preprocessor_directiveContext {
		public ITerminalNode ERROR() { return GetToken(CSharpPreprocessorParser.ERROR, 0); }
		public ITerminalNode TEXT() { return GetToken(CSharpPreprocessorParser.TEXT, 0); }
		public Directive_new_line_or_sharpContext directive_new_line_or_sharp() {
			return GetRuleContext<Directive_new_line_or_sharpContext>(0);
		}
		public ITerminalNode WARNING() { return GetToken(CSharpPreprocessorParser.WARNING, 0); }
		public PreprocessorDiagnosticContext(Preprocessor_directiveContext context) { CopyFrom(context); }
	}
	public partial class PreprocessorRegionContext : Preprocessor_directiveContext {
		public ITerminalNode REGION() { return GetToken(CSharpPreprocessorParser.REGION, 0); }
		public Directive_new_line_or_sharpContext directive_new_line_or_sharp() {
			return GetRuleContext<Directive_new_line_or_sharpContext>(0);
		}
		public ITerminalNode TEXT() { return GetToken(CSharpPreprocessorParser.TEXT, 0); }
		public ITerminalNode ENDREGION() { return GetToken(CSharpPreprocessorParser.ENDREGION, 0); }
		public PreprocessorRegionContext(Preprocessor_directiveContext context) { CopyFrom(context); }
	}
	public partial class PreprocessorDeclarationContext : Preprocessor_directiveContext {
		public IToken _CONDITIONAL_SYMBOL;
		public ITerminalNode DEFINE() { return GetToken(CSharpPreprocessorParser.DEFINE, 0); }
		public ITerminalNode CONDITIONAL_SYMBOL() { return GetToken(CSharpPreprocessorParser.CONDITIONAL_SYMBOL, 0); }
		public Directive_new_line_or_sharpContext directive_new_line_or_sharp() {
			return GetRuleContext<Directive_new_line_or_sharpContext>(0);
		}
		public ITerminalNode UNDEF() { return GetToken(CSharpPreprocessorParser.UNDEF, 0); }
		public PreprocessorDeclarationContext(Preprocessor_directiveContext context) { CopyFrom(context); }
	}
	public partial class PreprocessorConditionalContext : Preprocessor_directiveContext {
		public Preprocessor_expressionContext expr;
		public ITerminalNode IF() { return GetToken(CSharpPreprocessorParser.IF, 0); }
		public Directive_new_line_or_sharpContext directive_new_line_or_sharp() {
			return GetRuleContext<Directive_new_line_or_sharpContext>(0);
		}
		public Preprocessor_expressionContext preprocessor_expression() {
			return GetRuleContext<Preprocessor_expressionContext>(0);
		}
		public ITerminalNode ELIF() { return GetToken(CSharpPreprocessorParser.ELIF, 0); }
		public ITerminalNode ELSE() { return GetToken(CSharpPreprocessorParser.ELSE, 0); }
		public ITerminalNode ENDIF() { return GetToken(CSharpPreprocessorParser.ENDIF, 0); }
		public PreprocessorConditionalContext(Preprocessor_directiveContext context) { CopyFrom(context); }
	}
	public partial class PreprocessorPragmaContext : Preprocessor_directiveContext {
		public ITerminalNode PRAGMA() { return GetToken(CSharpPreprocessorParser.PRAGMA, 0); }
		public ITerminalNode TEXT() { return GetToken(CSharpPreprocessorParser.TEXT, 0); }
		public Directive_new_line_or_sharpContext directive_new_line_or_sharp() {
			return GetRuleContext<Directive_new_line_or_sharpContext>(0);
		}
		public PreprocessorPragmaContext(Preprocessor_directiveContext context) { CopyFrom(context); }
	}
	public partial class PreprocessorLineContext : Preprocessor_directiveContext {
		public ITerminalNode LINE() { return GetToken(CSharpPreprocessorParser.LINE, 0); }
		public Directive_new_line_or_sharpContext directive_new_line_or_sharp() {
			return GetRuleContext<Directive_new_line_or_sharpContext>(0);
		}
		public ITerminalNode DIGITS() { return GetToken(CSharpPreprocessorParser.DIGITS, 0); }
		public ITerminalNode DEFAULT() { return GetToken(CSharpPreprocessorParser.DEFAULT, 0); }
		public ITerminalNode DIRECTIVE_HIDDEN() { return GetToken(CSharpPreprocessorParser.DIRECTIVE_HIDDEN, 0); }
		public ITerminalNode STRING() { return GetToken(CSharpPreprocessorParser.STRING, 0); }
		public PreprocessorLineContext(Preprocessor_directiveContext context) { CopyFrom(context); }
	}

	[RuleVersion(0)]
	public Preprocessor_directiveContext preprocessor_directive() {
		Preprocessor_directiveContext _localctx = new Preprocessor_directiveContext(Context, State);
		EnterRule(_localctx, 0, RULE_preprocessor_directive);
		int _la;
		try {
			State = 75;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case DEFINE:
				_localctx = new PreprocessorDeclarationContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 6; Match(DEFINE);
				State = 7; ((PreprocessorDeclarationContext)_localctx)._CONDITIONAL_SYMBOL = Match(CONDITIONAL_SYMBOL);
				State = 8; directive_new_line_or_sharp();
				 ConditionalSymbols.Add((((PreprocessorDeclarationContext)_localctx)._CONDITIONAL_SYMBOL!=null?((PreprocessorDeclarationContext)_localctx)._CONDITIONAL_SYMBOL.Text:null));
					   ((PreprocessorDeclarationContext)_localctx).value =  conditions.All(c => c); 
				}
				break;
			case UNDEF:
				_localctx = new PreprocessorDeclarationContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 11; Match(UNDEF);
				State = 12; ((PreprocessorDeclarationContext)_localctx)._CONDITIONAL_SYMBOL = Match(CONDITIONAL_SYMBOL);
				State = 13; directive_new_line_or_sharp();
				 ConditionalSymbols.Remove((((PreprocessorDeclarationContext)_localctx)._CONDITIONAL_SYMBOL!=null?((PreprocessorDeclarationContext)_localctx)._CONDITIONAL_SYMBOL.Text:null));
					   ((PreprocessorDeclarationContext)_localctx).value =  conditions.All(c => c); 
				}
				break;
			case IF:
				_localctx = new PreprocessorConditionalContext(_localctx);
				EnterOuterAlt(_localctx, 3);
				{
				State = 16; Match(IF);
				State = 17; ((PreprocessorConditionalContext)_localctx).expr = preprocessor_expression(0);
				State = 18; directive_new_line_or_sharp();
				 ((PreprocessorConditionalContext)_localctx).value =  ((PreprocessorConditionalContext)_localctx).expr.value == "true" && conditions.All(c => c); conditions.Push(((PreprocessorConditionalContext)_localctx).expr.value == "true"); 
				}
				break;
			case ELIF:
				_localctx = new PreprocessorConditionalContext(_localctx);
				EnterOuterAlt(_localctx, 4);
				{
				State = 21; Match(ELIF);
				State = 22; ((PreprocessorConditionalContext)_localctx).expr = preprocessor_expression(0);
				State = 23; directive_new_line_or_sharp();
				 if (!conditions.Peek()) { conditions.Pop(); ((PreprocessorConditionalContext)_localctx).value =  ((PreprocessorConditionalContext)_localctx).expr.value == "true" && conditions.All(c => c);
					     conditions.Push(((PreprocessorConditionalContext)_localctx).expr.value == "true"); } else ((PreprocessorConditionalContext)_localctx).value =  false; 
				}
				break;
			case ELSE:
				_localctx = new PreprocessorConditionalContext(_localctx);
				EnterOuterAlt(_localctx, 5);
				{
				State = 26; Match(ELSE);
				State = 27; directive_new_line_or_sharp();
				 if (!conditions.Peek()) { conditions.Pop(); ((PreprocessorConditionalContext)_localctx).value =  true && conditions.All(c => c); conditions.Push(true); }
					    else ((PreprocessorConditionalContext)_localctx).value =  false; 
				}
				break;
			case ENDIF:
				_localctx = new PreprocessorConditionalContext(_localctx);
				EnterOuterAlt(_localctx, 6);
				{
				State = 30; Match(ENDIF);
				State = 31; directive_new_line_or_sharp();
				 conditions.Pop(); ((PreprocessorConditionalContext)_localctx).value =  conditions.Peek(); 
				}
				break;
			case LINE:
				_localctx = new PreprocessorLineContext(_localctx);
				EnterOuterAlt(_localctx, 7);
				{
				State = 34; Match(LINE);
				State = 41;
				ErrorHandler.Sync(this);
				switch (TokenStream.LA(1)) {
				case DIGITS:
					{
					State = 35; Match(DIGITS);
					State = 37;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
					if (_la==STRING) {
						{
						State = 36; Match(STRING);
						}
					}

					}
					break;
				case DEFAULT:
					{
					State = 39; Match(DEFAULT);
					}
					break;
				case DIRECTIVE_HIDDEN:
					{
					State = 40; Match(DIRECTIVE_HIDDEN);
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				State = 43; directive_new_line_or_sharp();
				 ((PreprocessorLineContext)_localctx).value =  conditions.All(c => c); 
				}
				break;
			case ERROR:
				_localctx = new PreprocessorDiagnosticContext(_localctx);
				EnterOuterAlt(_localctx, 8);
				{
				State = 46; Match(ERROR);
				State = 47; Match(TEXT);
				State = 48; directive_new_line_or_sharp();
				 ((PreprocessorDiagnosticContext)_localctx).value =  conditions.All(c => c); 
				}
				break;
			case WARNING:
				_localctx = new PreprocessorDiagnosticContext(_localctx);
				EnterOuterAlt(_localctx, 9);
				{
				State = 51; Match(WARNING);
				State = 52; Match(TEXT);
				State = 53; directive_new_line_or_sharp();
				 ((PreprocessorDiagnosticContext)_localctx).value =  conditions.All(c => c); 
				}
				break;
			case REGION:
				_localctx = new PreprocessorRegionContext(_localctx);
				EnterOuterAlt(_localctx, 10);
				{
				State = 56; Match(REGION);
				State = 58;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==TEXT) {
					{
					State = 57; Match(TEXT);
					}
				}

				State = 60; directive_new_line_or_sharp();
				 ((PreprocessorRegionContext)_localctx).value =  conditions.All(c => c); 
				}
				break;
			case ENDREGION:
				_localctx = new PreprocessorRegionContext(_localctx);
				EnterOuterAlt(_localctx, 11);
				{
				State = 63; Match(ENDREGION);
				State = 65;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==TEXT) {
					{
					State = 64; Match(TEXT);
					}
				}

				State = 67; directive_new_line_or_sharp();
				 ((PreprocessorRegionContext)_localctx).value =  conditions.All(c => c); 
				}
				break;
			case PRAGMA:
				_localctx = new PreprocessorPragmaContext(_localctx);
				EnterOuterAlt(_localctx, 12);
				{
				State = 70; Match(PRAGMA);
				State = 71; Match(TEXT);
				State = 72; directive_new_line_or_sharp();
				 ((PreprocessorPragmaContext)_localctx).value =  conditions.All(c => c); 
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Directive_new_line_or_sharpContext : ParserRuleContext {
		public ITerminalNode DIRECTIVE_NEW_LINE() { return GetToken(CSharpPreprocessorParser.DIRECTIVE_NEW_LINE, 0); }
		public ITerminalNode Eof() { return GetToken(CSharpPreprocessorParser.Eof, 0); }
		public Directive_new_line_or_sharpContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_directive_new_line_or_sharp; } }
	}

	[RuleVersion(0)]
	public Directive_new_line_or_sharpContext directive_new_line_or_sharp() {
		Directive_new_line_or_sharpContext _localctx = new Directive_new_line_or_sharpContext(Context, State);
		EnterRule(_localctx, 2, RULE_directive_new_line_or_sharp);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 77;
			_la = TokenStream.LA(1);
			if ( !(_la==Eof || _la==DIRECTIVE_NEW_LINE) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
				ErrorHandler.ReportMatch(this);
			    Consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Preprocessor_expressionContext : ParserRuleContext {
		public string value;
		public Preprocessor_expressionContext expr1;
		public IToken _CONDITIONAL_SYMBOL;
		public Preprocessor_expressionContext expr;
		public Preprocessor_expressionContext expr2;
		public ITerminalNode TRUE() { return GetToken(CSharpPreprocessorParser.TRUE, 0); }
		public ITerminalNode FALSE() { return GetToken(CSharpPreprocessorParser.FALSE, 0); }
		public ITerminalNode CONDITIONAL_SYMBOL() { return GetToken(CSharpPreprocessorParser.CONDITIONAL_SYMBOL, 0); }
		public ITerminalNode OPEN_PARENS() { return GetToken(CSharpPreprocessorParser.OPEN_PARENS, 0); }
		public ITerminalNode CLOSE_PARENS() { return GetToken(CSharpPreprocessorParser.CLOSE_PARENS, 0); }
		public Preprocessor_expressionContext[] preprocessor_expression() {
			return GetRuleContexts<Preprocessor_expressionContext>();
		}
		public Preprocessor_expressionContext preprocessor_expression(int i) {
			return GetRuleContext<Preprocessor_expressionContext>(i);
		}
		public ITerminalNode BANG() { return GetToken(CSharpPreprocessorParser.BANG, 0); }
		public ITerminalNode OP_EQ() { return GetToken(CSharpPreprocessorParser.OP_EQ, 0); }
		public ITerminalNode OP_NE() { return GetToken(CSharpPreprocessorParser.OP_NE, 0); }
		public ITerminalNode OP_AND() { return GetToken(CSharpPreprocessorParser.OP_AND, 0); }
		public ITerminalNode OP_OR() { return GetToken(CSharpPreprocessorParser.OP_OR, 0); }
		public Preprocessor_expressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_preprocessor_expression; } }
	}

	[RuleVersion(0)]
	public Preprocessor_expressionContext preprocessor_expression() {
		return preprocessor_expression(0);
	}

	private Preprocessor_expressionContext preprocessor_expression(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		Preprocessor_expressionContext _localctx = new Preprocessor_expressionContext(Context, _parentState);
		Preprocessor_expressionContext _prevctx = _localctx;
		int _startState = 4;
		EnterRecursionRule(_localctx, 4, RULE_preprocessor_expression, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 95;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case TRUE:
				{
				State = 80; Match(TRUE);
				 _localctx.value =  "true"; 
				}
				break;
			case FALSE:
				{
				State = 82; Match(FALSE);
				 _localctx.value =  "false"; 
				}
				break;
			case CONDITIONAL_SYMBOL:
				{
				State = 84; _localctx._CONDITIONAL_SYMBOL = Match(CONDITIONAL_SYMBOL);
				 _localctx.value =  ConditionalSymbols.Contains((_localctx._CONDITIONAL_SYMBOL!=null?_localctx._CONDITIONAL_SYMBOL.Text:null)) ? "true" : "false"; 
				}
				break;
			case OPEN_PARENS:
				{
				State = 86; Match(OPEN_PARENS);
				State = 87; _localctx.expr = preprocessor_expression(0);
				State = 88; Match(CLOSE_PARENS);
				 _localctx.value =  _localctx.expr.value; 
				}
				break;
			case BANG:
				{
				State = 91; Match(BANG);
				State = 92; _localctx.expr = preprocessor_expression(5);
				 _localctx.value =  _localctx.expr.value == "true" ? "false" : "true"; 
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			Context.Stop = TokenStream.LT(-1);
			State = 119;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,7,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 117;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,6,Context) ) {
					case 1:
						{
						_localctx = new Preprocessor_expressionContext(_parentctx, _parentState);
						_localctx.expr1 = _prevctx;
						PushNewRecursionContext(_localctx, _startState, RULE_preprocessor_expression);
						State = 97;
						if (!(Precpred(Context, 4))) throw new FailedPredicateException(this, "Precpred(Context, 4)");
						State = 98; Match(OP_EQ);
						State = 99; _localctx.expr2 = preprocessor_expression(5);
						 _localctx.value =  (_localctx.expr1.value == _localctx.expr2.value ? "true" : "false"); 
						}
						break;
					case 2:
						{
						_localctx = new Preprocessor_expressionContext(_parentctx, _parentState);
						_localctx.expr1 = _prevctx;
						PushNewRecursionContext(_localctx, _startState, RULE_preprocessor_expression);
						State = 102;
						if (!(Precpred(Context, 3))) throw new FailedPredicateException(this, "Precpred(Context, 3)");
						State = 103; Match(OP_NE);
						State = 104; _localctx.expr2 = preprocessor_expression(4);
						 _localctx.value =  (_localctx.expr1.value != _localctx.expr2.value ? "true" : "false"); 
						}
						break;
					case 3:
						{
						_localctx = new Preprocessor_expressionContext(_parentctx, _parentState);
						_localctx.expr1 = _prevctx;
						PushNewRecursionContext(_localctx, _startState, RULE_preprocessor_expression);
						State = 107;
						if (!(Precpred(Context, 2))) throw new FailedPredicateException(this, "Precpred(Context, 2)");
						State = 108; Match(OP_AND);
						State = 109; _localctx.expr2 = preprocessor_expression(3);
						 _localctx.value =  (_localctx.expr1.value == "true" && _localctx.expr2.value == "true" ? "true" : "false"); 
						}
						break;
					case 4:
						{
						_localctx = new Preprocessor_expressionContext(_parentctx, _parentState);
						_localctx.expr1 = _prevctx;
						PushNewRecursionContext(_localctx, _startState, RULE_preprocessor_expression);
						State = 112;
						if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
						State = 113; Match(OP_OR);
						State = 114; _localctx.expr2 = preprocessor_expression(2);
						 _localctx.value =  (_localctx.expr1.value == "true" || _localctx.expr2.value == "true" ? "true" : "false"); 
						}
						break;
					}
					} 
				}
				State = 121;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,7,Context);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 2: return preprocessor_expression_sempred((Preprocessor_expressionContext)_localctx, predIndex);
		}
		return true;
	}
	private bool preprocessor_expression_sempred(Preprocessor_expressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return Precpred(Context, 4);
		case 1: return Precpred(Context, 3);
		case 2: return Precpred(Context, 2);
		case 3: return Precpred(Context, 1);
		}
		return true;
	}

	private static string _serializedATN = _serializeATN();
	private static string _serializeATN()
	{
	    StringBuilder sb = new StringBuilder();
	    sb.Append("\x3\x430\xD6D1\x8206\xAD2D\x4417\xAEF1\x8D80\xAADD\x3\xC1");
		sb.Append("}\x4\x2\t\x2\x4\x3\t\x3\x4\x4\t\x4\x3\x2\x3\x2\x3\x2\x3\x2\x3");
		sb.Append("\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3");
		sb.Append("\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3");
		sb.Append("\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x5\x2(\n\x2\x3\x2\x3");
		sb.Append("\x2\x5\x2,\n\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3");
		sb.Append("\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x5\x2=\n\x2\x3");
		sb.Append("\x2\x3\x2\x3\x2\x3\x2\x3\x2\x5\x2\x44\n\x2\x3\x2\x3\x2\x3\x2");
		sb.Append("\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x5\x2N\n\x2\x3\x3\x3\x3\x3\x4");
		sb.Append("\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4");
		sb.Append("\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x5\x4\x62\n\x4\x3\x4\x3\x4\x3");
		sb.Append("\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3");
		sb.Append("\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\a\x4x\n\x4\f\x4");
		sb.Append("\xE\x4{\v\x4\x3\x4\x2\x3\x6\x5\x2\x4\x6\x2\x3\x3\x3\xBF\xBF");
		sb.Append("\x91\x2M\x3\x2\x2\x2\x4O\x3\x2\x2\x2\x6\x61\x3\x2\x2\x2\b\t");
		sb.Append("\a\xB3\x2\x2\t\n\a\xBE\x2\x2\n\v\x5\x4\x3\x2\v\f\b\x2\x1\x2");
		sb.Append("\fN\x3\x2\x2\x2\r\xE\a\xB4\x2\x2\xE\xF\a\xBE\x2\x2\xF\x10\x5");
		sb.Append("\x4\x3\x2\x10\x11\b\x2\x1\x2\x11N\x3\x2\x2\x2\x12\x13\a\x35");
		sb.Append("\x2\x2\x13\x14\x5\x6\x4\x2\x14\x15\x5\x4\x3\x2\x15\x16\b\x2");
		sb.Append("\x1\x2\x16N\x3\x2\x2\x2\x17\x18\a\xB5\x2\x2\x18\x19\x5\x6\x4");
		sb.Append("\x2\x19\x1A\x5\x4\x3\x2\x1A\x1B\b\x2\x1\x2\x1BN\x3\x2\x2\x2");
		sb.Append("\x1C\x1D\a%\x2\x2\x1D\x1E\x5\x4\x3\x2\x1E\x1F\b\x2\x1\x2\x1F");
		sb.Append("N\x3\x2\x2\x2 !\a\xB6\x2\x2!\"\x5\x4\x3\x2\"#\b\x2\x1\x2#N\x3");
		sb.Append("\x2\x2\x2$+\a\xB7\x2\x2%\'\a\xB2\x2\x2&(\a\\\x2\x2\'&\x3\x2");
		sb.Append("\x2\x2\'(\x3\x2\x2\x2(,\x3\x2\x2\x2),\a\x1F\x2\x2*,\a\xBD\x2");
		sb.Append("\x2+%\x3\x2\x2\x2+)\x3\x2\x2\x2+*\x3\x2\x2\x2,-\x3\x2\x2\x2");
		sb.Append("-.\x5\x4\x3\x2./\b\x2\x1\x2/N\x3\x2\x2\x2\x30\x31\a\xB8\x2\x2");
		sb.Append("\x31\x32\a\xC0\x2\x2\x32\x33\x5\x4\x3\x2\x33\x34\b\x2\x1\x2");
		sb.Append("\x34N\x3\x2\x2\x2\x35\x36\a\xB9\x2\x2\x36\x37\a\xC0\x2\x2\x37");
		sb.Append("\x38\x5\x4\x3\x2\x38\x39\b\x2\x1\x2\x39N\x3\x2\x2\x2:<\a\xBA");
		sb.Append("\x2\x2;=\a\xC0\x2\x2<;\x3\x2\x2\x2<=\x3\x2\x2\x2=>\x3\x2\x2");
		sb.Append("\x2>?\x5\x4\x3\x2?@\b\x2\x1\x2@N\x3\x2\x2\x2\x41\x43\a\xBB\x2");
		sb.Append("\x2\x42\x44\a\xC0\x2\x2\x43\x42\x3\x2\x2\x2\x43\x44\x3\x2\x2");
		sb.Append("\x2\x44\x45\x3\x2\x2\x2\x45\x46\x5\x4\x3\x2\x46G\b\x2\x1\x2");
		sb.Append("GN\x3\x2\x2\x2HI\a\xBC\x2\x2IJ\a\xC0\x2\x2JK\x5\x4\x3\x2KL\b");
		sb.Append("\x2\x1\x2LN\x3\x2\x2\x2M\b\x3\x2\x2\x2M\r\x3\x2\x2\x2M\x12\x3");
		sb.Append("\x2\x2\x2M\x17\x3\x2\x2\x2M\x1C\x3\x2\x2\x2M \x3\x2\x2\x2M$");
		sb.Append("\x3\x2\x2\x2M\x30\x3\x2\x2\x2M\x35\x3\x2\x2\x2M:\x3\x2\x2\x2");
		sb.Append("M\x41\x3\x2\x2\x2MH\x3\x2\x2\x2N\x3\x3\x2\x2\x2OP\t\x2\x2\x2");
		sb.Append("P\x5\x3\x2\x2\x2QR\b\x4\x1\x2RS\a\x61\x2\x2S\x62\b\x4\x1\x2");
		sb.Append("TU\a+\x2\x2U\x62\b\x4\x1\x2VW\a\xBE\x2\x2W\x62\b\x4\x1\x2XY");
		sb.Append("\a\x7F\x2\x2YZ\x5\x6\x4\x2Z[\a\x80\x2\x2[\\\b\x4\x1\x2\\\x62");
		sb.Append("\x3\x2\x2\x2]^\a\x8D\x2\x2^_\x5\x6\x4\a_`\b\x4\x1\x2`\x62\x3");
		sb.Append("\x2\x2\x2\x61Q\x3\x2\x2\x2\x61T\x3\x2\x2\x2\x61V\x3\x2\x2\x2");
		sb.Append("\x61X\x3\x2\x2\x2\x61]\x3\x2\x2\x2\x62y\x3\x2\x2\x2\x63\x64");
		sb.Append("\f\x6\x2\x2\x64\x65\a\x9A\x2\x2\x65\x66\x5\x6\x4\a\x66g\b\x4");
		sb.Append("\x1\x2gx\x3\x2\x2\x2hi\f\x5\x2\x2ij\a\x9B\x2\x2jk\x5\x6\x4\x6");
		sb.Append("kl\b\x4\x1\x2lx\x3\x2\x2\x2mn\f\x4\x2\x2no\a\x97\x2\x2op\x5");
		sb.Append("\x6\x4\x5pq\b\x4\x1\x2qx\x3\x2\x2\x2rs\f\x3\x2\x2st\a\x98\x2");
		sb.Append("\x2tu\x5\x6\x4\x4uv\b\x4\x1\x2vx\x3\x2\x2\x2w\x63\x3\x2\x2\x2");
		sb.Append("wh\x3\x2\x2\x2wm\x3\x2\x2\x2wr\x3\x2\x2\x2x{\x3\x2\x2\x2yw\x3");
		sb.Append("\x2\x2\x2yz\x3\x2\x2\x2z\a\x3\x2\x2\x2{y\x3\x2\x2\x2\n\'+<\x43");
		sb.Append("M\x61wy");
	    return sb.ToString();
	}

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());


}
} // namespace Santol.Parser.CSharp.Antlr
