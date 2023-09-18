namespace Antlr.MathCalculator;

internal class MathFunctions
{
    public decimal Sin(decimal value) => (decimal)Math.Sin((double)value);
    
    public decimal Cos(decimal value) => (decimal)Math.Cos((double)value);

    public decimal Max(decimal a, decimal b) => a > b ? a : b;

    public decimal Min(decimal a, decimal b) => a < b ? a : b;
}