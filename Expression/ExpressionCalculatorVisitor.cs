﻿using System.Globalization;
using System.Text.RegularExpressions;
using Antlr.Tools;
using Antlr4.Runtime.Misc;
using ExpressionAutogenerated;

namespace Antlr.Expression;

public class ExpressionCalculatorVisitor : ExpressionBaseVisitor<ExpressionCalculatorValue>
{
    private readonly IDictionary<string, ExpressionCalculatorValue> variables;
    private readonly IExpressionCalculatorFunctions functions;
    private readonly IDictionary<string, IExpressionList> lists;
    private readonly Action<string> functionsLog;
    private readonly Action<string> undefinedVariablesLog;
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

    public override ExpressionCalculatorValue VisitListLiteral(ExpressionParser.ListLiteralContext context) => ExpressionCalculatorValue.FromArrayOfObjects(context.atom().Select(VisitAtom));

    public override ExpressionCalculatorValue VisitListVariable(ExpressionParser.ListVariableContext context)
    {
        var listName = context.ID().GetText();
        if (!lists.ContainsKey(listName))
        {
            throw new ExpressionException($"List [{listName}] is not defined.");
        }
        return ExpressionCalculatorValue.FromExpressionList(listName, lists[listName]);
    }

    public override ExpressionCalculatorValue VisitEquation(ExpressionParser.EquationContext context)
    {
        var expressions = context.numericExpression();

        if (expressions.Length == 1)
            return Visit(expressions[0]);

        var v1 = Visit(expressions[0]);
        var v2 = Visit(expressions[1]);

        var g = context.cmpOp();
        var h = g.GetText();
        var cmpOp = ExpressionCompareOperatorTools.Parse(h);
        return cmpOp switch
        {
            ExpressionCompareOperator.EQ => ExpressionCalculatorValue.FromBool(v1.Equal(v2)),
            ExpressionCompareOperator.NOT_EQ => ExpressionCalculatorValue.FromBool(!v1.Equal(v2)),
            ExpressionCompareOperator.LT => ExpressionCalculatorValue.FromBool(v1.ToDecimal() < v2.ToDecimal()),
            ExpressionCompareOperator.GT => ExpressionCalculatorValue.FromBool(v1.ToDecimal() > v2.ToDecimal()),
            ExpressionCompareOperator.LT_OR_EQ => ExpressionCalculatorValue.FromBool(v1.ToDecimal() <= v2.ToDecimal()),
            ExpressionCompareOperator.GT_OR_EQ => ExpressionCalculatorValue.FromBool(v1.ToDecimal() >= v2.ToDecimal()),
            ExpressionCompareOperator.IN => ExpressionCalculatorValue.FromBool
            (
                v2.Type == ExpressionCalculatorValueType.Scalar
                ? v2.ToStr().Contains(v1.ToStr())
                : v2.ToList().Contains(v1)
                ),
            ExpressionCompareOperator.NOT_IN => ExpressionCalculatorValue.FromBool(
                v2.Type == ExpressionCalculatorValueType.Scalar
                ? !v2.ToStr().Contains(v1.ToStr())
                : !v2.ToList().Contains(v1)
                ),
            ExpressionCompareOperator.LIKE => ExpressionCalculatorValue.FromBool(LikeOperator.IsLike(v1.ToStr(), v2.ToStr())),
            _ => throw new ExpressionException("Unknown compare operator '$cmp_op'."),
        };
    }

    public override ExpressionCalculatorValue VisitScalarVariable(ExpressionParser.ScalarVariableContext context)
    {
        var text = context.GetText();
        if (text == "true") return ExpressionCalculatorValue.FromBool(true);
        if (text == "false") return ExpressionCalculatorValue.FromBool(false);
        if (text == "null") return ExpressionCalculatorValue.FromNull();
        if (text.StartsWith('&') || text.StartsWith('#'))
            text = text.Substring(1);
        if (!variables.ContainsKey(text))
        {
            if (undefinedVariablesLog != null)
            {
                undefinedVariablesLog.Invoke(text);
            }
            return ExpressionCalculatorValue.FromString(string.Empty);
        }

        return variables[text];
    }

    public override ExpressionCalculatorValue VisitScientific(ExpressionParser.ScientificContext context)
    {
        var text = context.GetText();
        var result = decimal.TryParse(text, CultureInfo.InvariantCulture, out var d);
        return result
            ? ExpressionCalculatorValue.FromDecimal(d)
            : throw new ExpressionException($"Bad input [{text}] awaiting decimal");
    }

    public override ExpressionCalculatorValue VisitMultiplyingExpression(ExpressionParser.MultiplyingExpressionContext context)
    {
        if (context.powExpression().Length == 1)
            return Visit(context.powExpression()[0]);

        var result = Visit(context.powExpression(0)).ToDecimal();

        for (var i = 1; i < context.ChildCount; i += 2)
        {
            var op = context.GetChild(i).GetText();
            switch (op)
            {
                case "*":
                    result *= Visit(context.GetChild(i + 1)).ToDecimal();
                    break;
                case "/":
                    result /= Visit(context.GetChild(i + 1)).ToDecimal();
                    break;
                case "%":
                    result %= Visit(context.GetChild(i + 1)).ToDecimal();
                    break;
                default:
                    throw new ExpressionException($"Unknown operator [{op}] in mul/div/mod.");
            }
        }
        return ExpressionCalculatorValue.FromDecimal(result);
    }

    public override ExpressionCalculatorValue VisitNumericExpression(ExpressionParser.NumericExpressionContext context)
    {
        if (context.multiplyingExpression().Length == 1)
            return Visit(context.GetChild(0));

        var result = Visit(context.GetChild(0)).ToDecimal();
        for (var i = 1; i < context.ChildCount; i += 2)
        {
            var op = context.GetChild(i).GetText();
            switch (op)
            {
                case "+":
                    result += Visit(context.GetChild(i + 1)).ToDecimal();
                    break;
                case "-":
                    result -= Visit(context.GetChild(i + 1)).ToDecimal();
                    break;
                default:
                    throw new ExpressionException($"Unknown operator [{op}] in add/sub");
            }
        }
        return ExpressionCalculatorValue.FromDecimal(result);
    }

    public override ExpressionCalculatorValue VisitPowExpression(ExpressionParser.PowExpressionContext context)
    {
        if (context.atom().Length == 1)
            return Visit(context.atom(0));
        var v1 = Visit(context.atom(0)).ToDecimal();
        var v2 = Visit(context.atom(1)).ToDecimal();

        var result = (decimal)Math.Pow((double)v1, (double)v2);
        return ExpressionCalculatorValue.FromDecimal(result);
    }

    public override ExpressionCalculatorValue VisitString(ExpressionParser.StringContext context) 
        => ExpressionCalculatorValue.FromString(StringParser.Parse(context.GetText()));

    public override ExpressionCalculatorValue VisitFunc(ExpressionParser.FuncContext context)
    {
        var funcName = context.funcName().GetText();

        var funcParams = new Dictionary<string, ExpressionCalculatorValue>();
        if (context.parameters() != null)
        {
            var parameters = context.parameters().parameter();
            foreach (var parameter in parameters)
            {
                var paramName = parameter.paramName() != null ? parameter.paramName().GetText() : string.Empty; //todo

                if (functions.IsParameterWantFieldName(funcName, paramName))
                {
                    var field = parameter.paramValue().GetText();

                    if (!Regex.Match(field, "^[a-zA-Z_]\\w*$").Success)
                    {
                        throw new ExpressionException("Field name expected in function '$func_name' parameter '$param_name'.");
                    }
                    funcParams[paramName] = ExpressionCalculatorValue.FromString(field);
                }
                else
                {
                    funcParams[paramName] = Visit(parameter.paramValue());
                }
            }
        }
        return functions.Call(funcName, funcParams, functionsLog);
    }

    public override ExpressionCalculatorValue VisitSimpleFilter(ExpressionParser.SimpleFilterContext context)
    {
        return ExpressionCalculatorValue.FromFilter(
            context.Start.InputStream.GetText(new Interval(context.Start.StartIndex, context.Stop.StopIndex)),
                new SimpleFilter(
                    context.simpleFilterExpression().Select(x => new SimpleFilterExpression
                        (
                            "",
                            x.simpleFilterExpressionField().GetText(),
                            ExpressionCompareOperatorTools.Parse(x.cmpOp().GetText()),
                            new Expression(x.simpleFilterExpressionValue().GetText())
                        )
                    )));
    }

    public override ExpressionCalculatorValue VisitNotExpression(ExpressionParser.NotExpressionContext context)
        => ExpressionCalculatorValue.FromBool(!Visit(context.notExpressionInner()).ToBool());

    public override ExpressionCalculatorValue VisitGroup(ExpressionParser.GroupContext context)
        => Visit(context.logicExpression());

    public override ExpressionCalculatorValue VisitUnaryMinus(ExpressionParser.UnaryMinusContext context)
        => ExpressionCalculatorValue.FromDecimal(-Visit(context.minusable()).ToDecimal());
}