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

    [Fact]
    public void InnerTextATagReturnsStrings()
    {
        //Assign
        var input = "<div> <p>A <b>regular expression</b>, <b>regex</b> or <b>regexp</b> (sometimes called a <b>rational expression</b>) is, in <a href=\"https://en.wikipedia.org/wiki/Theoretical_computer_science\" title=\"Theoretical computer science\">theoretical computer science</a> and <a href=\"https://en.wikipedia.org/wiki/Formal_language\" title=\"Formal language\">formal language</a> theory, a sequence of <a href=\"https://en.wikipedia.org/wiki/Character_(computing)\" title=\"Character (computing)\">characters</a> that define a <i>search <a href=\"https://en.wikipedia.org/wiki/Pattern_matching\" title=\"Pattern matching\">pattern</a></i>. Usually this pattern is then used by <a href=\"https://en.wikipedia.org/wiki/String_searching_algorithm\" title=\"String searching algorithm\">string searching algorithms</a> for \"find\" or \"find and replace\" operations on <a href=\"https://en.wikipedia.org/wiki/String_(computer_science)\" title=\"String (computer science)\">strings</a>.</p></ div > ";

        var tag = "a";


        //act
        


        //assert

        Assert.Equal(new List<string>() { "theoretical computer science", "formal language", "characters", "pattern", "string searching algorithms", "strings" }, RegExpr.InnerText(input, tag));
    }
    [Fact]
    public void UrlsReturnsStringURLTitle()
    {
        //Assign
        var input = " <a href=\"https://en.wikipedia.org/wiki/Theoretical_computer_science\" title=\"Theoretical computer science\">theoretical computer science</a> and <a href=\"https://en.wikipedia.org/wiki/Formal_language\" title=\"Formal language\">formal language</a>";

        //act



        //assert

        Assert.Equal(new List<string>() { "https://en.wikipedia.org/wiki/Theoretical_computer_science Theoretical computer science", "https://en.wikipedia.org/wiki/Formal_language Formal language" }, RegExpr.Urls(input));
    }

    [Fact]
    public void UrlsWithoutTitleReturnsInnerText()
    {
        //Assign
        var input = " <a href=\"https://en.wikipedia.org/wiki/Theoretical_computer_science\" >theoretical computer science</a> and <a href=\"https://en.wikipedia.org/wiki/Formal_language\" title=\"Formal language\">formal language</a>";

        //act



        //assert

        Assert.Equal(new List<string>() { "theoretical computer science", "https://en.wikipedia.org/wiki/Formal_language Formal language" }, RegExpr.Urls(input));
    }
}