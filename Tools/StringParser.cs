using System.Text.RegularExpressions;
using Antlr.Expression;

namespace Antlr.Tools;

internal static class StringParser
{
    public static string Parse(string input)
    {
        return Regex.Replace(input, "/\\[\"'rnt]/", match =>
        {
            return match.Value switch
            {
                "\\" => "\\",
                "\\\"" => "\"",
                "\\'" => "\'",
                "\\r" => "\r",
                "\\n" => "\n",
                "\\t" => "\t",
                _ => throw new ExpressionException($"Unknown escaping sequence [{match.Value}] in string [{input}]")
            };
        });
    }
}