using Antlr.Tools;

namespace Antlr.Expression;

public static class ExpressionCompareOperatorTools
{
    public static ExpressionCompareOperator Parse(string s) =>
        StringManipulation.PregReplace(s,new []{"^NOT\\s+IN$"}, new []{"NOT IN"}) switch
        {
            "==" => ExpressionCompareOperator.EQ,
            "!=" => ExpressionCompareOperator.NOT_EQ,
            "<" => ExpressionCompareOperator.LT,
            "<=" => ExpressionCompareOperator.LT_OR_EQ,
            ">" => ExpressionCompareOperator.GT,
            ">=" => ExpressionCompareOperator.GT_OR_EQ,
            "IN" => ExpressionCompareOperator.IN,
            "NOT IN" => ExpressionCompareOperator.NOT_IN,
            "LIKE" => ExpressionCompareOperator.LIKE,
            _ => throw new Exception($"Bad operator [{s}]")
        };
}

public enum ExpressionCompareOperator
{
    EQ,
    NOT_EQ,
    LT,
    LT_OR_EQ,
    GT,
    GT_OR_EQ,
    IN,
    NOT_IN,
    LIKE
}