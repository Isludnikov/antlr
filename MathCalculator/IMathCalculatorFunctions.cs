namespace Antlr.MathCalculator;

internal interface IMathCalculatorFunctions
{
    public decimal Call(string name, Dictionary<string, decimal> funcParams); 
}