//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from D:/home/sludnikovi/repos/Antlr_expression/MathCalculator.g4 by ANTLR 4.13.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace MathCalculatorAutogenerated {
using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.1")]
[System.CLSCompliant(false)]
public partial class MathCalculatorParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		STRING=1, PLUSMINUSOP=2, MULDIVMODOP=3, LET=4, LPAREN=5, RPAREN=6, PLUS=7, 
		MINUS=8, MUL=9, DIV=10, MOD=11, POINT=12, E=13, POW=14, COMMA=15, DIGIT=16, 
		ID=17, WS=18;
	public const int
		RULE_numericExpression = 0, RULE_multiplyingExpression = 1, RULE_powExpression = 2, 
		RULE_unaryMinus = 3, RULE_atom = 4, RULE_group = 5, RULE_scientific = 6, 
		RULE_func = 7, RULE_parameters = 8, RULE_parameter = 9, RULE_funcName = 10, 
		RULE_paramName = 11, RULE_paramValue = 12, RULE_number = 13, RULE_scalarVariable = 14;
	public static readonly string[] ruleNames = {
		"numericExpression", "multiplyingExpression", "powExpression", "unaryMinus", 
		"atom", "group", "scientific", "func", "parameters", "parameter", "funcName", 
		"paramName", "paramValue", "number", "scalarVariable"
	};

	private static readonly string[] _LiteralNames = {
		null, null, null, null, "'='", "'('", "')'", "'+'", "'-'", "'*'", "'/'", 
		"'%'", "'.'", null, "'^'", "','"
	};
	private static readonly string[] _SymbolicNames = {
		null, "STRING", "PLUSMINUSOP", "MULDIVMODOP", "LET", "LPAREN", "RPAREN", 
		"PLUS", "MINUS", "MUL", "DIV", "MOD", "POINT", "E", "POW", "COMMA", "DIGIT", 
		"ID", "WS"
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

	public override string GrammarFileName { get { return "MathCalculator.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static MathCalculatorParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public MathCalculatorParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public MathCalculatorParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class NumericExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public MultiplyingExpressionContext[] multiplyingExpression() {
			return GetRuleContexts<MultiplyingExpressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public MultiplyingExpressionContext multiplyingExpression(int i) {
			return GetRuleContext<MultiplyingExpressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] PLUSMINUSOP() { return GetTokens(MathCalculatorParser.PLUSMINUSOP); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PLUSMINUSOP(int i) {
			return GetToken(MathCalculatorParser.PLUSMINUSOP, i);
		}
		public NumericExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_numericExpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMathCalculatorVisitor<TResult> typedVisitor = visitor as IMathCalculatorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitNumericExpression(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public NumericExpressionContext numericExpression() {
		NumericExpressionContext _localctx = new NumericExpressionContext(Context, State);
		EnterRule(_localctx, 0, RULE_numericExpression);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 30;
			multiplyingExpression();
			State = 35;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==PLUSMINUSOP) {
				{
				{
				State = 31;
				Match(PLUSMINUSOP);
				State = 32;
				multiplyingExpression();
				}
				}
				State = 37;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
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

	public partial class MultiplyingExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public PowExpressionContext[] powExpression() {
			return GetRuleContexts<PowExpressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public PowExpressionContext powExpression(int i) {
			return GetRuleContext<PowExpressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] MULDIVMODOP() { return GetTokens(MathCalculatorParser.MULDIVMODOP); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode MULDIVMODOP(int i) {
			return GetToken(MathCalculatorParser.MULDIVMODOP, i);
		}
		public MultiplyingExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_multiplyingExpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMathCalculatorVisitor<TResult> typedVisitor = visitor as IMathCalculatorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMultiplyingExpression(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public MultiplyingExpressionContext multiplyingExpression() {
		MultiplyingExpressionContext _localctx = new MultiplyingExpressionContext(Context, State);
		EnterRule(_localctx, 2, RULE_multiplyingExpression);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 38;
			powExpression();
			State = 43;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==MULDIVMODOP) {
				{
				{
				State = 39;
				Match(MULDIVMODOP);
				State = 40;
				powExpression();
				}
				}
				State = 45;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
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

	public partial class PowExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public UnaryMinusContext[] unaryMinus() {
			return GetRuleContexts<UnaryMinusContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public UnaryMinusContext unaryMinus(int i) {
			return GetRuleContext<UnaryMinusContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode POW() { return GetToken(MathCalculatorParser.POW, 0); }
		public PowExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_powExpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMathCalculatorVisitor<TResult> typedVisitor = visitor as IMathCalculatorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPowExpression(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public PowExpressionContext powExpression() {
		PowExpressionContext _localctx = new PowExpressionContext(Context, State);
		EnterRule(_localctx, 4, RULE_powExpression);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 46;
			unaryMinus();
			State = 49;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==POW) {
				{
				State = 47;
				Match(POW);
				State = 48;
				unaryMinus();
				}
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

	public partial class UnaryMinusContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public AtomContext atom() {
			return GetRuleContext<AtomContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode MINUS() { return GetToken(MathCalculatorParser.MINUS, 0); }
		public UnaryMinusContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_unaryMinus; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMathCalculatorVisitor<TResult> typedVisitor = visitor as IMathCalculatorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitUnaryMinus(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public UnaryMinusContext unaryMinus() {
		UnaryMinusContext _localctx = new UnaryMinusContext(Context, State);
		EnterRule(_localctx, 6, RULE_unaryMinus);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 52;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==MINUS) {
				{
				State = 51;
				Match(MINUS);
				}
			}

			State = 54;
			atom();
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

	public partial class AtomContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ScientificContext scientific() {
			return GetRuleContext<ScientificContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ScalarVariableContext scalarVariable() {
			return GetRuleContext<ScalarVariableContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public GroupContext group() {
			return GetRuleContext<GroupContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public FuncContext func() {
			return GetRuleContext<FuncContext>(0);
		}
		public AtomContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_atom; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMathCalculatorVisitor<TResult> typedVisitor = visitor as IMathCalculatorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAtom(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public AtomContext atom() {
		AtomContext _localctx = new AtomContext(Context, State);
		EnterRule(_localctx, 8, RULE_atom);
		try {
			State = 60;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,4,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 56;
				scientific();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 57;
				scalarVariable();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 58;
				group();
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 59;
				func();
				}
				break;
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

	public partial class GroupContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(MathCalculatorParser.LPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public NumericExpressionContext numericExpression() {
			return GetRuleContext<NumericExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(MathCalculatorParser.RPAREN, 0); }
		public GroupContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_group; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMathCalculatorVisitor<TResult> typedVisitor = visitor as IMathCalculatorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitGroup(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public GroupContext group() {
		GroupContext _localctx = new GroupContext(Context, State);
		EnterRule(_localctx, 10, RULE_group);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 62;
			Match(LPAREN);
			State = 63;
			numericExpression();
			State = 64;
			Match(RPAREN);
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

	public partial class ScientificContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public NumberContext[] number() {
			return GetRuleContexts<NumberContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public NumberContext number(int i) {
			return GetRuleContext<NumberContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode E() { return GetToken(MathCalculatorParser.E, 0); }
		public ScientificContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_scientific; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMathCalculatorVisitor<TResult> typedVisitor = visitor as IMathCalculatorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitScientific(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ScientificContext scientific() {
		ScientificContext _localctx = new ScientificContext(Context, State);
		EnterRule(_localctx, 12, RULE_scientific);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 66;
			number();
			State = 69;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==E) {
				{
				State = 67;
				Match(E);
				State = 68;
				number();
				}
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

	public partial class FuncContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public FuncNameContext funcName() {
			return GetRuleContext<FuncNameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(MathCalculatorParser.LPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(MathCalculatorParser.RPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ParametersContext parameters() {
			return GetRuleContext<ParametersContext>(0);
		}
		public FuncContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_func; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMathCalculatorVisitor<TResult> typedVisitor = visitor as IMathCalculatorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitFunc(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public FuncContext func() {
		FuncContext _localctx = new FuncContext(Context, State);
		EnterRule(_localctx, 14, RULE_func);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 71;
			funcName();
			State = 72;
			Match(LPAREN);
			State = 74;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & 196896L) != 0)) {
				{
				State = 73;
				parameters();
				}
			}

			State = 76;
			Match(RPAREN);
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

	public partial class ParametersContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ParameterContext[] parameter() {
			return GetRuleContexts<ParameterContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ParameterContext parameter(int i) {
			return GetRuleContext<ParameterContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(MathCalculatorParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(MathCalculatorParser.COMMA, i);
		}
		public ParametersContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_parameters; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMathCalculatorVisitor<TResult> typedVisitor = visitor as IMathCalculatorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitParameters(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ParametersContext parameters() {
		ParametersContext _localctx = new ParametersContext(Context, State);
		EnterRule(_localctx, 16, RULE_parameters);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 78;
			parameter();
			State = 83;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==COMMA) {
				{
				{
				State = 79;
				Match(COMMA);
				State = 80;
				parameter();
				}
				}
				State = 85;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
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

	public partial class ParameterContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ParamValueContext paramValue() {
			return GetRuleContext<ParamValueContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ParamNameContext paramName() {
			return GetRuleContext<ParamNameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LET() { return GetToken(MathCalculatorParser.LET, 0); }
		public ParameterContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_parameter; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMathCalculatorVisitor<TResult> typedVisitor = visitor as IMathCalculatorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitParameter(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ParameterContext parameter() {
		ParameterContext _localctx = new ParameterContext(Context, State);
		EnterRule(_localctx, 18, RULE_parameter);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 89;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,8,Context) ) {
			case 1:
				{
				State = 86;
				paramName();
				State = 87;
				Match(LET);
				}
				break;
			}
			State = 91;
			paramValue();
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

	public partial class FuncNameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ID() { return GetToken(MathCalculatorParser.ID, 0); }
		public FuncNameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_funcName; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMathCalculatorVisitor<TResult> typedVisitor = visitor as IMathCalculatorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitFuncName(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public FuncNameContext funcName() {
		FuncNameContext _localctx = new FuncNameContext(Context, State);
		EnterRule(_localctx, 20, RULE_funcName);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 93;
			Match(ID);
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

	public partial class ParamNameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ID() { return GetToken(MathCalculatorParser.ID, 0); }
		public ParamNameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_paramName; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMathCalculatorVisitor<TResult> typedVisitor = visitor as IMathCalculatorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitParamName(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ParamNameContext paramName() {
		ParamNameContext _localctx = new ParamNameContext(Context, State);
		EnterRule(_localctx, 22, RULE_paramName);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 95;
			Match(ID);
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

	public partial class ParamValueContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public NumericExpressionContext numericExpression() {
			return GetRuleContext<NumericExpressionContext>(0);
		}
		public ParamValueContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_paramValue; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMathCalculatorVisitor<TResult> typedVisitor = visitor as IMathCalculatorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitParamValue(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ParamValueContext paramValue() {
		ParamValueContext _localctx = new ParamValueContext(Context, State);
		EnterRule(_localctx, 24, RULE_paramValue);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 97;
			numericExpression();
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

	public partial class NumberContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] DIGIT() { return GetTokens(MathCalculatorParser.DIGIT); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DIGIT(int i) {
			return GetToken(MathCalculatorParser.DIGIT, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode POINT() { return GetToken(MathCalculatorParser.POINT, 0); }
		public NumberContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_number; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMathCalculatorVisitor<TResult> typedVisitor = visitor as IMathCalculatorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitNumber(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public NumberContext number() {
		NumberContext _localctx = new NumberContext(Context, State);
		EnterRule(_localctx, 26, RULE_number);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 100;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			do {
				{
				{
				State = 99;
				Match(DIGIT);
				}
				}
				State = 102;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( _la==DIGIT );
			State = 110;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==POINT) {
				{
				State = 104;
				Match(POINT);
				State = 106;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				do {
					{
					{
					State = 105;
					Match(DIGIT);
					}
					}
					State = 108;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				} while ( _la==DIGIT );
				}
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

	public partial class ScalarVariableContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] ID() { return GetTokens(MathCalculatorParser.ID); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ID(int i) {
			return GetToken(MathCalculatorParser.ID, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] POINT() { return GetTokens(MathCalculatorParser.POINT); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode POINT(int i) {
			return GetToken(MathCalculatorParser.POINT, i);
		}
		public ScalarVariableContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_scalarVariable; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMathCalculatorVisitor<TResult> typedVisitor = visitor as IMathCalculatorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitScalarVariable(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ScalarVariableContext scalarVariable() {
		ScalarVariableContext _localctx = new ScalarVariableContext(Context, State);
		EnterRule(_localctx, 28, RULE_scalarVariable);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 112;
			Match(ID);
			State = 117;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==POINT) {
				{
				{
				State = 113;
				Match(POINT);
				State = 114;
				Match(ID);
				}
				}
				State = 119;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
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

	private static int[] _serializedATN = {
		4,1,18,121,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,6,2,7,
		7,7,2,8,7,8,2,9,7,9,2,10,7,10,2,11,7,11,2,12,7,12,2,13,7,13,2,14,7,14,
		1,0,1,0,1,0,5,0,34,8,0,10,0,12,0,37,9,0,1,1,1,1,1,1,5,1,42,8,1,10,1,12,
		1,45,9,1,1,2,1,2,1,2,3,2,50,8,2,1,3,3,3,53,8,3,1,3,1,3,1,4,1,4,1,4,1,4,
		3,4,61,8,4,1,5,1,5,1,5,1,5,1,6,1,6,1,6,3,6,70,8,6,1,7,1,7,1,7,3,7,75,8,
		7,1,7,1,7,1,8,1,8,1,8,5,8,82,8,8,10,8,12,8,85,9,8,1,9,1,9,1,9,3,9,90,8,
		9,1,9,1,9,1,10,1,10,1,11,1,11,1,12,1,12,1,13,4,13,101,8,13,11,13,12,13,
		102,1,13,1,13,4,13,107,8,13,11,13,12,13,108,3,13,111,8,13,1,14,1,14,1,
		14,5,14,116,8,14,10,14,12,14,119,9,14,1,14,0,0,15,0,2,4,6,8,10,12,14,16,
		18,20,22,24,26,28,0,0,120,0,30,1,0,0,0,2,38,1,0,0,0,4,46,1,0,0,0,6,52,
		1,0,0,0,8,60,1,0,0,0,10,62,1,0,0,0,12,66,1,0,0,0,14,71,1,0,0,0,16,78,1,
		0,0,0,18,89,1,0,0,0,20,93,1,0,0,0,22,95,1,0,0,0,24,97,1,0,0,0,26,100,1,
		0,0,0,28,112,1,0,0,0,30,35,3,2,1,0,31,32,5,2,0,0,32,34,3,2,1,0,33,31,1,
		0,0,0,34,37,1,0,0,0,35,33,1,0,0,0,35,36,1,0,0,0,36,1,1,0,0,0,37,35,1,0,
		0,0,38,43,3,4,2,0,39,40,5,3,0,0,40,42,3,4,2,0,41,39,1,0,0,0,42,45,1,0,
		0,0,43,41,1,0,0,0,43,44,1,0,0,0,44,3,1,0,0,0,45,43,1,0,0,0,46,49,3,6,3,
		0,47,48,5,14,0,0,48,50,3,6,3,0,49,47,1,0,0,0,49,50,1,0,0,0,50,5,1,0,0,
		0,51,53,5,8,0,0,52,51,1,0,0,0,52,53,1,0,0,0,53,54,1,0,0,0,54,55,3,8,4,
		0,55,7,1,0,0,0,56,61,3,12,6,0,57,61,3,28,14,0,58,61,3,10,5,0,59,61,3,14,
		7,0,60,56,1,0,0,0,60,57,1,0,0,0,60,58,1,0,0,0,60,59,1,0,0,0,61,9,1,0,0,
		0,62,63,5,5,0,0,63,64,3,0,0,0,64,65,5,6,0,0,65,11,1,0,0,0,66,69,3,26,13,
		0,67,68,5,13,0,0,68,70,3,26,13,0,69,67,1,0,0,0,69,70,1,0,0,0,70,13,1,0,
		0,0,71,72,3,20,10,0,72,74,5,5,0,0,73,75,3,16,8,0,74,73,1,0,0,0,74,75,1,
		0,0,0,75,76,1,0,0,0,76,77,5,6,0,0,77,15,1,0,0,0,78,83,3,18,9,0,79,80,5,
		15,0,0,80,82,3,18,9,0,81,79,1,0,0,0,82,85,1,0,0,0,83,81,1,0,0,0,83,84,
		1,0,0,0,84,17,1,0,0,0,85,83,1,0,0,0,86,87,3,22,11,0,87,88,5,4,0,0,88,90,
		1,0,0,0,89,86,1,0,0,0,89,90,1,0,0,0,90,91,1,0,0,0,91,92,3,24,12,0,92,19,
		1,0,0,0,93,94,5,17,0,0,94,21,1,0,0,0,95,96,5,17,0,0,96,23,1,0,0,0,97,98,
		3,0,0,0,98,25,1,0,0,0,99,101,5,16,0,0,100,99,1,0,0,0,101,102,1,0,0,0,102,
		100,1,0,0,0,102,103,1,0,0,0,103,110,1,0,0,0,104,106,5,12,0,0,105,107,5,
		16,0,0,106,105,1,0,0,0,107,108,1,0,0,0,108,106,1,0,0,0,108,109,1,0,0,0,
		109,111,1,0,0,0,110,104,1,0,0,0,110,111,1,0,0,0,111,27,1,0,0,0,112,117,
		5,17,0,0,113,114,5,12,0,0,114,116,5,17,0,0,115,113,1,0,0,0,116,119,1,0,
		0,0,117,115,1,0,0,0,117,118,1,0,0,0,118,29,1,0,0,0,119,117,1,0,0,0,13,
		35,43,49,52,60,69,74,83,89,102,108,110,117
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace MathCalculatorAutogenerated