//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from D:/home/sludnikovi/repos/Antlr_expression/Expression.g4 by ANTLR 4.13.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace ExpressionAutogenerated {
using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.1")]
[System.CLSCompliant(false)]
public partial class ExpressionLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, STRING=4, LET=5, LPAREN=6, RPAREN=7, LLIST=8, 
		RLIST=9, PLUS=10, MINUS=11, MUL=12, DIV=13, MOD=14, GT_OR_EQ=15, LT_OR_EQ=16, 
		GT=17, LT=18, EQ=19, POINT=20, IN=21, NOT_IN=22, NE=23, LIKE=24, E=25, 
		POW=26, OR=27, AND=28, COMMA=29, NOT=30, DIGIT=31, ID=32, WS=33;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "STRING", "LET", "LPAREN", "RPAREN", "LLIST", 
		"RLIST", "PLUS", "MINUS", "MUL", "DIV", "MOD", "GT_OR_EQ", "LT_OR_EQ", 
		"GT", "LT", "EQ", "POINT", "IN", "NOT_IN", "NE", "LIKE", "E", "POW", "OR", 
		"AND", "COMMA", "NOT", "DIGIT", "ID", "WS"
	};


	public ExpressionLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public ExpressionLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'{'", "'}'", "'@'", null, "'='", "'('", "')'", "'['", "']'", "'+'", 
		"'-'", "'*'", "'/'", "'%'", "'>='", "'<='", "'>'", "'<'", "'=='", "'.'", 
		"'IN'", null, null, "'LIKE'", null, "'^'", null, null, "','"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, "STRING", "LET", "LPAREN", "RPAREN", "LLIST", 
		"RLIST", "PLUS", "MINUS", "MUL", "DIV", "MOD", "GT_OR_EQ", "LT_OR_EQ", 
		"GT", "LT", "EQ", "POINT", "IN", "NOT_IN", "NE", "LIKE", "E", "POW", "OR", 
		"AND", "COMMA", "NOT", "DIGIT", "ID", "WS"
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

	public override string GrammarFileName { get { return "Expression.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static ExpressionLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static int[] _serializedATN = {
		4,0,33,193,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,
		6,2,7,7,7,2,8,7,8,2,9,7,9,2,10,7,10,2,11,7,11,2,12,7,12,2,13,7,13,2,14,
		7,14,2,15,7,15,2,16,7,16,2,17,7,17,2,18,7,18,2,19,7,19,2,20,7,20,2,21,
		7,21,2,22,7,22,2,23,7,23,2,24,7,24,2,25,7,25,2,26,7,26,2,27,7,27,2,28,
		7,28,2,29,7,29,2,30,7,30,2,31,7,31,2,32,7,32,1,0,1,0,1,1,1,1,1,2,1,2,1,
		3,1,3,1,3,1,3,5,3,78,8,3,10,3,12,3,81,9,3,1,3,1,3,1,3,1,3,1,3,5,3,88,8,
		3,10,3,12,3,91,9,3,1,3,3,3,94,8,3,1,4,1,4,1,5,1,5,1,6,1,6,1,7,1,7,1,8,
		1,8,1,9,1,9,1,10,1,10,1,11,1,11,1,12,1,12,1,13,1,13,1,14,1,14,1,14,1,15,
		1,15,1,15,1,16,1,16,1,17,1,17,1,18,1,18,1,18,1,19,1,19,1,20,1,20,1,20,
		1,21,1,21,1,21,1,21,1,21,1,21,1,21,1,21,1,22,1,22,1,22,1,22,3,22,146,8,
		22,1,23,1,23,1,23,1,23,1,23,1,24,1,24,1,25,1,25,1,26,1,26,1,26,1,26,3,
		26,161,8,26,1,27,1,27,1,27,1,27,1,27,3,27,168,8,27,1,28,1,28,1,29,1,29,
		1,29,1,29,3,29,176,8,29,1,30,1,30,1,31,1,31,5,31,182,8,31,10,31,12,31,
		185,9,31,1,32,4,32,188,8,32,11,32,12,32,189,1,32,1,32,0,0,33,1,1,3,2,5,
		3,7,4,9,5,11,6,13,7,15,8,17,9,19,10,21,11,23,12,25,13,27,14,29,15,31,16,
		33,17,35,18,37,19,39,20,41,21,43,22,45,23,47,24,49,25,51,26,53,27,55,28,
		57,29,59,30,61,31,63,32,65,33,1,0,7,1,0,92,92,2,0,34,34,92,92,2,0,39,39,
		92,92,2,0,69,69,101,101,3,0,65,90,95,95,97,122,4,0,48,57,65,90,95,95,97,
		122,3,0,9,10,13,13,32,32,203,0,1,1,0,0,0,0,3,1,0,0,0,0,5,1,0,0,0,0,7,1,
		0,0,0,0,9,1,0,0,0,0,11,1,0,0,0,0,13,1,0,0,0,0,15,1,0,0,0,0,17,1,0,0,0,
		0,19,1,0,0,0,0,21,1,0,0,0,0,23,1,0,0,0,0,25,1,0,0,0,0,27,1,0,0,0,0,29,
		1,0,0,0,0,31,1,0,0,0,0,33,1,0,0,0,0,35,1,0,0,0,0,37,1,0,0,0,0,39,1,0,0,
		0,0,41,1,0,0,0,0,43,1,0,0,0,0,45,1,0,0,0,0,47,1,0,0,0,0,49,1,0,0,0,0,51,
		1,0,0,0,0,53,1,0,0,0,0,55,1,0,0,0,0,57,1,0,0,0,0,59,1,0,0,0,0,61,1,0,0,
		0,0,63,1,0,0,0,0,65,1,0,0,0,1,67,1,0,0,0,3,69,1,0,0,0,5,71,1,0,0,0,7,93,
		1,0,0,0,9,95,1,0,0,0,11,97,1,0,0,0,13,99,1,0,0,0,15,101,1,0,0,0,17,103,
		1,0,0,0,19,105,1,0,0,0,21,107,1,0,0,0,23,109,1,0,0,0,25,111,1,0,0,0,27,
		113,1,0,0,0,29,115,1,0,0,0,31,118,1,0,0,0,33,121,1,0,0,0,35,123,1,0,0,
		0,37,125,1,0,0,0,39,128,1,0,0,0,41,130,1,0,0,0,43,133,1,0,0,0,45,145,1,
		0,0,0,47,147,1,0,0,0,49,152,1,0,0,0,51,154,1,0,0,0,53,160,1,0,0,0,55,167,
		1,0,0,0,57,169,1,0,0,0,59,175,1,0,0,0,61,177,1,0,0,0,63,179,1,0,0,0,65,
		187,1,0,0,0,67,68,5,123,0,0,68,2,1,0,0,0,69,70,5,125,0,0,70,4,1,0,0,0,
		71,72,5,64,0,0,72,6,1,0,0,0,73,79,5,34,0,0,74,75,7,0,0,0,75,78,2,0,65534,
		0,76,78,8,1,0,0,77,74,1,0,0,0,77,76,1,0,0,0,78,81,1,0,0,0,79,77,1,0,0,
		0,79,80,1,0,0,0,80,82,1,0,0,0,81,79,1,0,0,0,82,94,5,34,0,0,83,89,5,39,
		0,0,84,85,7,0,0,0,85,88,2,0,65534,0,86,88,8,2,0,0,87,84,1,0,0,0,87,86,
		1,0,0,0,88,91,1,0,0,0,89,87,1,0,0,0,89,90,1,0,0,0,90,92,1,0,0,0,91,89,
		1,0,0,0,92,94,5,39,0,0,93,73,1,0,0,0,93,83,1,0,0,0,94,8,1,0,0,0,95,96,
		5,61,0,0,96,10,1,0,0,0,97,98,5,40,0,0,98,12,1,0,0,0,99,100,5,41,0,0,100,
		14,1,0,0,0,101,102,5,91,0,0,102,16,1,0,0,0,103,104,5,93,0,0,104,18,1,0,
		0,0,105,106,5,43,0,0,106,20,1,0,0,0,107,108,5,45,0,0,108,22,1,0,0,0,109,
		110,5,42,0,0,110,24,1,0,0,0,111,112,5,47,0,0,112,26,1,0,0,0,113,114,5,
		37,0,0,114,28,1,0,0,0,115,116,5,62,0,0,116,117,5,61,0,0,117,30,1,0,0,0,
		118,119,5,60,0,0,119,120,5,61,0,0,120,32,1,0,0,0,121,122,5,62,0,0,122,
		34,1,0,0,0,123,124,5,60,0,0,124,36,1,0,0,0,125,126,5,61,0,0,126,127,5,
		61,0,0,127,38,1,0,0,0,128,129,5,46,0,0,129,40,1,0,0,0,130,131,5,73,0,0,
		131,132,5,78,0,0,132,42,1,0,0,0,133,134,5,78,0,0,134,135,5,79,0,0,135,
		136,5,84,0,0,136,137,1,0,0,0,137,138,3,65,32,0,138,139,5,73,0,0,139,140,
		5,78,0,0,140,44,1,0,0,0,141,142,5,60,0,0,142,146,5,62,0,0,143,144,5,33,
		0,0,144,146,5,61,0,0,145,141,1,0,0,0,145,143,1,0,0,0,146,46,1,0,0,0,147,
		148,5,76,0,0,148,149,5,73,0,0,149,150,5,75,0,0,150,151,5,69,0,0,151,48,
		1,0,0,0,152,153,7,3,0,0,153,50,1,0,0,0,154,155,5,94,0,0,155,52,1,0,0,0,
		156,157,5,79,0,0,157,161,5,82,0,0,158,159,5,124,0,0,159,161,5,124,0,0,
		160,156,1,0,0,0,160,158,1,0,0,0,161,54,1,0,0,0,162,163,5,65,0,0,163,164,
		5,78,0,0,164,168,5,68,0,0,165,166,5,38,0,0,166,168,5,38,0,0,167,162,1,
		0,0,0,167,165,1,0,0,0,168,56,1,0,0,0,169,170,5,44,0,0,170,58,1,0,0,0,171,
		172,5,78,0,0,172,173,5,79,0,0,173,176,5,84,0,0,174,176,5,33,0,0,175,171,
		1,0,0,0,175,174,1,0,0,0,176,60,1,0,0,0,177,178,2,48,57,0,178,62,1,0,0,
		0,179,183,7,4,0,0,180,182,7,5,0,0,181,180,1,0,0,0,182,185,1,0,0,0,183,
		181,1,0,0,0,183,184,1,0,0,0,184,64,1,0,0,0,185,183,1,0,0,0,186,188,7,6,
		0,0,187,186,1,0,0,0,188,189,1,0,0,0,189,187,1,0,0,0,189,190,1,0,0,0,190,
		191,1,0,0,0,191,192,6,32,0,0,192,66,1,0,0,0,12,0,77,79,87,89,93,145,160,
		167,175,183,189,1,0,1,0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace ExpressionAutogenerated
