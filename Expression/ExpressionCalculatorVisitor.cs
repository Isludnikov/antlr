﻿using ExpressionAutogenerated;

namespace Antlr.Expression;

public class ExpressionCalculatorVisitor : ExpressionBaseVisitor<ExpressionCalculatorValue>
{
    private IDictionary<string, ExpressionCalculatorValue> variables;
    private IExpressionCalculatorFunctions functions;
    private IDictionary<string, IExpressionList> lists;
    private Action<string> functionsLog;
    private Action<string> undefinedVariablesLog;
    public ExpressionCalculatorVisitor(IDictionary<string, ExpressionCalculatorValue> variables, IExpressionCalculatorFunctions functions, IDictionary<string, IExpressionList> lists, Action<string> functionsLog, Action<string> undefinedVariablesLog)
    {
        this.variables = variables;
        this.functions = functions;
        this.lists = lists;
        this.functionsLog = functionsLog;
        this.undefinedVariablesLog = undefinedVariablesLog;
    }

    public override ExpressionCalculatorValue VisitLogicExpression(ExpressionParser.LogicExpressionContext context)
    {
        var equations = context.andEquation();
        return equations.Length == 1 ? Visit(equations[0]) : ExpressionCalculatorValue.FromBool(equations.Any(equation => Visit(equation).ToBool()));
    }

    public override ExpressionCalculatorValue VisitAndEquation(ExpressionParser.AndEquationContext context)
    {
        var equations = context.equation();
        return equations.Length == 1 ? Visit(equations[0]) : ExpressionCalculatorValue.FromBool(equations.All(equation => Visit(equation).ToBool()));
    }
}