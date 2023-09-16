namespace Antlr.Expression;

public class SimpleFilterExpression
{
    public string Name;
    public string StringExpression;
    public ExpressionCompareOperator CompareOperator;
    public Expression Expression;
    public SimpleFilterExpression(string name, string stringExpression, ExpressionCompareOperator compareOperator, Expression expression)
    {
        Name = name;
        StringExpression = stringExpression;
        CompareOperator = compareOperator;
        Expression = expression;
    }
}