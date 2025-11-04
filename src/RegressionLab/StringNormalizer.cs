using System.Text.RegularExpressions;

namespace RegressionLab;

public static class StringNormalizer
{
    // BUGS: сохраняет подчеркивания и строчные буквы, множественные разделители не сворачиваются.
    public static string NormalizeProductCode(string? raw)
    {
        if (raw == null) return string.Empty;
        var s = raw.Trim();
        // Bug: сохраняйте подчеркивания/символы, не используйте заглавные буквы
        s = Regex.Replace(s, "\s+", "-");
        return s;
    }
}

