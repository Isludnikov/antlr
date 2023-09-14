namespace Antlr.Expression;

public interface IExpressionList
{
    public int Count();

    public bool Contains(ExpressionCalculatorValue value);

    public IExpressionList Remove(List<ExpressionCalculatorValue> elements);

    public IExpressionList GetUniqueElements();

    public List<ExpressionCalculatorValue> ToList();
}