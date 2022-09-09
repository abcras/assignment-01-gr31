namespace Assignment1;
using static Iterators;

public class Assignment1
{
    public static void Main(string[] args)
    {

        IEnumerable<IEnumerable<int>> input = new List<List<int>>();
        //input.Append(Enumerable.Empty<int>());
        input.Append(new List<int>() { 1, 2, 3, 4, 5, 6, 7, 10 });
        input.Append(new List<int>() { 12, 34, 56, 710 });

        IEnumerable<int> res = new List<int>();
        //Act
        //var result = Flatten(input);

        foreach (var item in Flatten(input))
        {
            res.Append(item);
        }

    }

}