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
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="MathCalculatorParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.1")]
[System.CLSCompliant(false)]
public interface IMathCalculatorVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="MathCalculatorParser.numericExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNumericExpression([NotNull] MathCalculatorParser.NumericExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MathCalculatorParser.multiplyingExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMultiplyingExpression([NotNull] MathCalculatorParser.MultiplyingExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MathCalculatorParser.powExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPowExpression([NotNull] MathCalculatorParser.PowExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MathCalculatorParser.unaryMinus"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUnaryMinus([NotNull] MathCalculatorParser.UnaryMinusContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MathCalculatorParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAtom([NotNull] MathCalculatorParser.AtomContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MathCalculatorParser.group"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGroup([NotNull] MathCalculatorParser.GroupContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MathCalculatorParser.scientific"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitScientific([NotNull] MathCalculatorParser.ScientificContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MathCalculatorParser.func"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunc([NotNull] MathCalculatorParser.FuncContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MathCalculatorParser.parameters"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParameters([NotNull] MathCalculatorParser.ParametersContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MathCalculatorParser.parameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParameter([NotNull] MathCalculatorParser.ParameterContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MathCalculatorParser.funcName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFuncName([NotNull] MathCalculatorParser.FuncNameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MathCalculatorParser.paramName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParamName([NotNull] MathCalculatorParser.ParamNameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MathCalculatorParser.paramValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParamValue([NotNull] MathCalculatorParser.ParamValueContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MathCalculatorParser.number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNumber([NotNull] MathCalculatorParser.NumberContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MathCalculatorParser.scalarVariable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitScalarVariable([NotNull] MathCalculatorParser.ScalarVariableContext context);
}
} // namespace MathCalculatorAutogenerated