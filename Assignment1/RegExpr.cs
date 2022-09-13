namespace Assignment1;
using System.Text.RegularExpressions;

public static class RegExpr
{
    public static IEnumerable<string> SplitLine(IEnumerable<string> lines)
    {
        Regex regex = new Regex(@"(\w+)");
        foreach (string line in lines)
        {
            var matches = regex.Matches(line);
            foreach (Match match in matches)
            {
                yield return match.Value;
            }
        }
        //yield break;
        //return new List<string>();
    }

    public static IEnumerable<(int width, int height)> Resolution(IEnumerable<string> resolutions)
    {
        Regex regex = new Regex(@"(?<length>\d+)x(?<width>\d+)");


        foreach (var res in resolutions)
        {

            var matches = regex.Matches(res);
            foreach (Match match in matches)
            {
                int l = int.Parse(match.Groups["length"].Value);
                int w = int.Parse(match.Groups["width"].Value);

                yield return (l, w);
            }
        }
    }

    public static IEnumerable<string> InnerText(string html, string tag)
    {
        string tmp = @$"\<{tag}.*?>(.*?)\<\/{tag}>";
        Regex innerText = new Regex(tmp);

        foreach (Match match in innerText.Matches(html))
        {
            yield return match.Groups[1].Value;
        }
    }

    public static IEnumerable<string> Urls(string html)
    {
        string tag = "a";
        string quotes = "\"(.*?)\"";
        Regex RegInnerText = new Regex(@$"\<{tag}.*?>(.*?)\<\/{tag}>");
        Regex RegQuotes = new Regex(quotes);

        foreach (Match match in RegInnerText.Matches(html))
        {
            string tmp = string.Empty;
            int twice = 0;
            foreach (Match match2 in RegQuotes.Matches(match.Groups[0].Value))
            {
                tmp += " " +match2.Groups[1].Value;
                twice++;
            }
            if (twice == 2)
            {
                yield return tmp.Trim();
            }
            else
            {
                yield return match.Groups[1].Value;
            }
        }
    }
}