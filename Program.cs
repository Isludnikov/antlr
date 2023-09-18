// See https://aka.ms/new-console-template for more information

using Antlr.Expression;
using Antlr.MathCalculator;

var list = new List<string>
{
    "1+2>1^(6+3)",
    "1 IN [3, 2, 1]",
    "true == (1 > 0)",
    "1 > -2",
    "PI >  3",
    "Sin(0) < 0.01",
    "5 > Max(3,1)",
    "EXP > 2"

};
var variables = new Dictionary<string, ExpressionCalculatorValue>
{
    { "PI", ExpressionCalculatorValue.FromDecimal((decimal)Math.PI) },
    { "EXP", ExpressionCalculatorValue.FromDecimal((decimal)Math.E) }
};
var functions = new ExpressionCalculatorFunctions(new ExpressionFunctions());

foreach (var elem in list)
{
    var expression = new Expression(elem);
    var result = expression.Calculate(variables,
        functions,
        new Dictionary<string, IExpressionList>(),
        Console.WriteLine,
        Console.WriteLine);
    Console.WriteLine($"{elem} <=> {result.ToBool()}");
    Console.WriteLine(result.ToBool());
}
Console.WriteLine("==========================================================================");
var mathList = new List<string>
{
    "1+1",
    "Sin(PI*0.5)",
    "Cos(PI*0.5)",
    "Sin(PI*0.5) + Cos(PI*0.5)",
    "2^10",
    "5*8",
    "5+6*2",
    "(5+6)*2",
    "-24",
    "5+(-6)",
    "5-(-6)"
};
var mathVariables = new Dictionary<string, decimal>
{
    { "PI", (decimal)Math.PI },
    { "EXP", (decimal)Math.E }
};
var mathFunctions = new MathCalculatorFunctions(new MathFunctions());
foreach (var math in mathList)
{
    var mathExpression = new MathExpression(math);
    var result = mathExpression.Calculate(mathVariables, mathFunctions);
    Console.WriteLine($"{math} = {result}");
}