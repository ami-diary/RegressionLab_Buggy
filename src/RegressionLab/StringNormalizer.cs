using System.Text.RegularExpressions;

namespace RegressionLab;

public static class StringNormalizer
{
    // BUGS: сохран€ет подчеркивани€ и строчные буквы, множественные разделители не сворачиваютс€.
    public static string NormalizeProductCode(string? raw)
    {
        if (raw == null) return string.Empty;
        var s = raw.Trim();
        // Bug: сохран€йте подчеркивани€/символы, не используйте заглавные буквы
        s = Regex.Replace(s, "\s+", "-");
        return s;
    }
}
