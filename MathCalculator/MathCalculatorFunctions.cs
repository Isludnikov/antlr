namespace Antlr.MathCalculator;

public class MathCalculatorFunctions : IMathCalculatorFunctions
{
    private readonly object functions;

    public MathCalculatorFunctions(object functions)
    {
        this.functions = functions;
    }


    public decimal Call(string name, Dictionary<string, decimal> funcParams)
    {
        var errors = new List<Exception>();
        var method = functions.GetType().GetMethod(name);
        var parameters = method.GetParameters();
        var actualParameters = new List<object>(parameters.Length);
        for (var i = 0; i < parameters.Length; ++i)
        {
            decimal value;
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
                value = (decimal)formalParameter.DefaultValue;
            }
            else
            {
                throw new Exception($"No value for parameter [{formalParameter.Name}] function [{name}]");
            }

            actualParameters.Add(value);
        }

        var ret = 0m;
        try
        {
            var result = method.Invoke(functions, actualParameters.ToArray());
            ret = (decimal)result;
        }
        catch (Exception exc)
        {
            errors.Add(exc);
        }
        return ret;
    }
}