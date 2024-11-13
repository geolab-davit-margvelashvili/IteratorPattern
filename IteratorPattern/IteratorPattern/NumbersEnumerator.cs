using System.Collections;

namespace IteratorPattern;

public class NumbersEnumerator : IEnumerator<int>
{
    private int _current = 0;

    private int _maxValue;

    public NumbersEnumerator(int maxValue)
    {
        _maxValue = maxValue;
    }

    public void Dispose()
    {
    }

    public bool MoveNext()
    {
        _current++;
        return _current <= _maxValue;
    }

    public void Reset()
    {
        _current = 0;
    }

    public int Current => _current;

    object? IEnumerator.Current => Current;
}

public class NumbersGenerator : IEnumerable<int>
{
    private readonly int _count;

    public NumbersGenerator(int count)
    {
        _count = count;
    }

    public IEnumerator<int> GetEnumerator()
    {
        return new NumbersEnumerator(_count);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}