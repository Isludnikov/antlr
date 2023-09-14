namespace Antlr.Expression;

public class ExpressionCalculatorValue
{
    public ExpressionCalculatorValueType Type;
    private string scalarString;
    private decimal scalarDecimal;
    private List<ExpressionCalculatorValue> listLiteral;
    private IExpressionList listReference;
    private SimpleFilter filter;
    public ExpressionCalculatorValue(ExpressionCalculatorValueType type, string scalarString, decimal scalarDecimal, List<ExpressionCalculatorValue> listLiteral = null, IExpressionList listReference = null, SimpleFilter filter = null)
    {
        Type = type;
        this.scalarString = scalarString;
        this.scalarDecimal = scalarDecimal;
        this.listLiteral = listLiteral;
        this.listReference = listReference;
        this.filter = filter;
    }

    public bool IsTrue() => scalarDecimal == 1m && scalarString == "true";

    public bool IsFalse() => scalarDecimal == 0m && scalarString == "false";

    public bool IsNull() => scalarDecimal == 0m && scalarString == "null";

    public bool ToBool()
    {
        if (Type == ExpressionCalculatorValueType.Scalar)
        {
            if (IsTrue()) return true;
            if (IsFalse() || IsNull()) return false;
        }

        throw new ExpressionException($"Boolean value expected ('{Type}' found).");
    }

    internal static ExpressionCalculatorValue FromBool(bool v)
    {
        return new ExpressionCalculatorValue(ExpressionCalculatorValueType.Scalar, "true", 1);
    }
}

public enum ExpressionCalculatorValueType
{
    Scalar,
    ListLiteral,
    ListReference,
    Filter
}