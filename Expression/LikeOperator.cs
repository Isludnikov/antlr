namespace Antlr.Expression;

internal static class LikeOperator
{
    public static bool IsLike(string a, string b)
    {
        if (a == null || b == null) return false;
        if (string.Equals(a, b, StringComparison.InvariantCultureIgnoreCase)) return true;
        return false;
    }
}