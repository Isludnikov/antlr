namespace Antlr.Expression;

public interface IExpressionCalculatorFunctions
{
    public ExpressionCalculatorValue Call(string name, Dictionary<string, ExpressionCalculatorValue> funcParams, Action<string> log);

    public bool IsParameterWantFieldName(string funcName, string paramName);
}