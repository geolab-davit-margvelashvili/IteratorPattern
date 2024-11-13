namespace IteratorPattern;

public static class Functions
{
    public static IEnumerable<int> GetNumbersByNumbersGenerator(int count)
    {
        return new NumbersGenerator(count);
    }

    public static IEnumerable<int> GetNumbersByYieldReturn(int count)
    {
        for (int i = 1; i <= count; i++)
        {
            yield return i;
        }
    }
}