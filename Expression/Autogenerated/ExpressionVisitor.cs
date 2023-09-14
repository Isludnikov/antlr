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
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="ExpressionParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.1")]
[System.CLSCompliant(false)]
public interface IExpressionVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="ExpressionParser.logicExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLogicExpression([NotNull] ExpressionParser.LogicExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ExpressionParser.andEquation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAndEquation([NotNull] ExpressionParser.AndEquationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ExpressionParser.equation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEquation([NotNull] ExpressionParser.EquationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ExpressionParser.numericExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNumericExpression([NotNull] ExpressionParser.NumericExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ExpressionParser.multiplyingExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMultiplyingExpression([NotNull] ExpressionParser.MultiplyingExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ExpressionParser.powExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPowExpression([NotNull] ExpressionParser.PowExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ExpressionParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAtom([NotNull] ExpressionParser.AtomContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ExpressionParser.unaryMinus"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUnaryMinus([NotNull] ExpressionParser.UnaryMinusContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ExpressionParser.minusable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMinusable([NotNull] ExpressionParser.MinusableContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ExpressionParser.group"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGroup([NotNull] ExpressionParser.GroupContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ExpressionParser.scientific"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitScientific([NotNull] ExpressionParser.ScientificContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ExpressionParser.string"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitString([NotNull] ExpressionParser.StringContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ExpressionParser.func"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunc([NotNull] ExpressionParser.FuncContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ExpressionParser.parameters"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParameters([NotNull] ExpressionParser.ParametersContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ExpressionParser.parameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParameter([NotNull] ExpressionParser.ParameterContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ExpressionParser.funcName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFuncName([NotNull] ExpressionParser.FuncNameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ExpressionParser.paramName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParamName([NotNull] ExpressionParser.ParamNameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ExpressionParser.paramValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParamValue([NotNull] ExpressionParser.ParamValueContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ExpressionParser.metaFilter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMetaFilter([NotNull] ExpressionParser.MetaFilterContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ExpressionParser.simpleFilter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSimpleFilter([NotNull] ExpressionParser.SimpleFilterContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ExpressionParser.simpleFilterExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSimpleFilterExpression([NotNull] ExpressionParser.SimpleFilterExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ExpressionParser.simpleFilterExpressionField"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSimpleFilterExpressionField([NotNull] ExpressionParser.SimpleFilterExpressionFieldContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ExpressionParser.simpleFilterExpressionValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSimpleFilterExpressionValue([NotNull] ExpressionParser.SimpleFilterExpressionValueContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ExpressionParser.cmpOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmpOp([NotNull] ExpressionParser.CmpOpContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ExpressionParser.number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNumber([NotNull] ExpressionParser.NumberContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ExpressionParser.scalarVariable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitScalarVariable([NotNull] ExpressionParser.ScalarVariableContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ExpressionParser.listLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitListLiteral([NotNull] ExpressionParser.ListLiteralContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ExpressionParser.listVariable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitListVariable([NotNull] ExpressionParser.ListVariableContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ExpressionParser.notExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNotExpression([NotNull] ExpressionParser.NotExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ExpressionParser.notExpressionInner"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNotExpressionInner([NotNull] ExpressionParser.NotExpressionInnerContext context);
}
} // namespace ExpressionAutogenerated