// See https://aka.ms/new-console-template for more information

using Antlr.Expression;

var str = "11>1";
var expression = new Expression(str);
var result = expression.Calculate(new Dictionary<string, ExpressionCalculatorValue>(), null, new Dictionary<string, IExpressionList>(), null, null);
Console.WriteLine(str);
Console.WriteLine(result.ToBool());