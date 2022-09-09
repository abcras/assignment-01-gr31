namespace Assignment1.Tests;

public class RegExprTests
{



    [Fact]
    public void SplitsLinesSentencesIntoWords()
    {
        var input = new List<string>()
        {
        "HEJ JEG ER EN KAGE",
        "MEOW SAGDE KATTEN"
        };

        Assert.Equal(new List<string>() { "HEJ", "JEG", "ER", "EN", "KAGE", "MEOW", "SAGDE", "KATTEN" }, RegExpr.SplitLine(input));

    }


    [Fact]
    public void ResolutionEnumerableOfStrings()
    {
        var input = new List<string>()
        {
        "1920x1080, 720x1080",
        "320x240"
        };

        Assert.Equal(new List<(int, int)>() { (1920,1080), (720, 1080), (320, 240) }, RegExpr.Resolution(input));

    }
}