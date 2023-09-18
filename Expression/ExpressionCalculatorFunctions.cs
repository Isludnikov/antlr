using System.Reflection;

namespace Antlr.Expression;

public class ExpressionCalculatorFunctions : IExpressionCalculatorFunctions
{
    private readonly object functions;

    public ExpressionCalculatorFunctions(object functions)
    {
        this.functions = functions;
    }
    public ExpressionCalculatorValue Call(string name, Dictionary<string, ExpressionCalculatorValue> funcParams, Action<string> log)
    {
        var errors = new List<ExpressionException>();
        var method = GetMethod(name);
        var parameters = method.GetParameters();
        var actualParameters = new List<object>(parameters.Length);
        for (var i = 0; i < parameters.Length; ++i)
        {
            ExpressionCalculatorValue value;
            var formalParameter = parameters[i];

            if (funcParams.TryGetValue(formalParameter.Name, out var param))
            {
                value = param;
            }
            else if (funcParams.TryGetValue(i.ToString(), out var param2))
            {
                value = param2;
            }
            else if (formalParameter.HasDefaultValue)
            {
                value = ExpressionCalculatorValue.FromObject(formalParameter.DefaultValue);
            }
            else
            {
                throw new Exception($"No value for parameter [{formalParameter.Name}] function [{name}]");
            }

            var type = formalParameter.ParameterType;
            actualParameters.Add(value.ToType(type));
        }

        var ret = ExpressionCalculatorValue.FromNull();
        try
        {
            var result = method.Invoke(functions, actualParameters.ToArray());
            ret = ExpressionCalculatorValue.FromObject(result);
        }
        catch (ExpressionException exc)
        {
            errors.Add(exc);
            log?.Invoke(exc.Message);
        }
        catch (Exception e)
        {
            log?.Invoke(e.Message);
            throw;
        }
        return ret;
    }

    private MethodInfo GetMethod(string name) => functions.GetType().GetMethod(name);

    public bool IsParameterWantFieldName(string funcName, string paramName)
    {
        return false;
    }
}