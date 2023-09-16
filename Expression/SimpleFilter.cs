namespace Antlr.Expression;

public class SimpleFilter
{
    public SimpleFilter(IEnumerable<SimpleFilterExpression> filters)
    {
        Expressions = filters.ToList();
    }
    public List<SimpleFilterExpression> Expressions;
}