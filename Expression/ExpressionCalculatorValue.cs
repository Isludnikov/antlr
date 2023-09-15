using System.Globalization;

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
    public bool Equal(ExpressionCalculatorValue obj)
    {
        if (obj == this) {
            return true;
        }

        return scalarDecimal == obj.scalarDecimal
            && scalarString == obj.scalarString
            && (
                (listLiteral == null && obj.listLiteral == null)
            || (listLiteral?.SequenceEqual(obj.listLiteral)??false)
            );
    }

    internal static ExpressionCalculatorValue FromBool(bool v) => new(ExpressionCalculatorValueType.Scalar, v ? "true" : "false", v ? 1 : 0);
    internal static ExpressionCalculatorValue FromNull() => new(ExpressionCalculatorValueType.Scalar, null, 0);
    internal static ExpressionCalculatorValue FromArrayOfObjects(IEnumerable<ExpressionCalculatorValue> list) => new(ExpressionCalculatorValueType.ListLiteral, null, 0, list.ToList());
    internal static ExpressionCalculatorValue FromExpressionList(string name, IExpressionList list) => new(ExpressionCalculatorValueType.ListReference, name, 0, null, list);

    internal decimal ToDecimal()
    {
        return Type switch
        {
            ExpressionCalculatorValueType.Scalar => scalarDecimal,
            _ => throw new ExpressionException($"Scalar expected [{Type}] found."),
        };
    }

    internal string ToStr()
    {
        return Type switch
        {
            ExpressionCalculatorValueType.Scalar => scalarString,
            _ => throw new ExpressionException($"Scalar expected [{Type}] found)."),
        };
    }
    public IExpressionList ToList()
    {
        return Type switch
        {
            ExpressionCalculatorValueType.ListLiteral => new ExpressionListLiteral(listLiteral),
            ExpressionCalculatorValueType.ListReference => listReference,
            _ => throw new ExpressionException($"List expected [{Type}] found)."),
        };
    }

    public static ExpressionCalculatorValue FromString(string str)
    {
        var parsingResult = decimal.TryParse(str, CultureInfo.InvariantCulture, out var d);
        return new ExpressionCalculatorValue(ExpressionCalculatorValueType.Scalar, str, parsingResult ? d : 0);
    }

    public static ExpressionCalculatorValue FromDecimal(decimal d) => new(ExpressionCalculatorValueType.Scalar, d.ToString(CultureInfo.InvariantCulture), d);
}

public enum ExpressionCalculatorValueType
{
    Scalar,
    ListLiteral,
    ListReference,
    Filter
}