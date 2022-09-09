namespace Assignment1;

public static class Iterators
{
    public static IEnumerable<T> Flatten<T>(IEnumerable<IEnumerable<T>> items)
    {
        List<int> tmp = new();
        foreach (var item in items)
        {
            foreach(var item2 in item)
            {
                //Console.WriteLine(item2);
                yield return item2;
            }
        }
        yield break;
    }

    public static IEnumerable<T> Filter<T>(IEnumerable<T> items, Predicate<T> predicate)
    {
        foreach (var item in items)
        {
            if (predicate(item))
                yield return item;
        }
    }
}