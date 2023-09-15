namespace Antlr.Expression;

internal class ExpressionListLiteral : IExpressionList
{
    private List<ExpressionCalculatorValue> list;

    public ExpressionListLiteral(IEnumerable<ExpressionCalculatorValue> enumerable)
    {
        list = enumerable.ToList();
    }
    public int Count() => list.Count;

    public bool Contains(ExpressionCalculatorValue value) => list.Contains(value);

    public IExpressionList Remove(List<ExpressionCalculatorValue> elements)
    {
        var t = new List<ExpressionCalculatorValue>(list);
        foreach (var e in elements)
        {
            t.Remove(e);
        }
        return new ExpressionListLiteral(t.ToList());
    }

    public IExpressionList GetUniqueElements()
    {
        var s = new HashSet<ExpressionCalculatorValue>();
        foreach (var a in list)
        {
            s.Add(a);
        }

        return new ExpressionListLiteral(s.ToList());
    }

    public List<ExpressionCalculatorValue> ToList() => list;
}