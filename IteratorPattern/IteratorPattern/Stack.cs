using System.Collections;

namespace IteratorPattern;

public class Stack<T> : IEnumerable<T>
{
    public sealed class StackEnumerator : IEnumerator<T>
    {
        private readonly List<T> _collection;
        private int _currentIndex;

        public StackEnumerator(List<T> collection)
        {
            _collection = collection;
            _currentIndex = collection.Count;
        }

        public bool MoveNext()
        {
            _currentIndex--;
            return _currentIndex >= 0;
        }

        public void Reset()
        {
            _currentIndex = _collection.Count;
        }

        public T Current => _collection[_currentIndex];

        object? IEnumerator.Current => Current;

        public void Dispose()
        {
            Reset();
        }
    }

    private List<T> _collection;

    public Stack()
    {
        _collection = new List<T>();
    }

    public void Push(T value)
    {
        _collection.Add(value);
    }

    public T Pick()
    {
        if (_collection.Count == 0)
            throw new InvalidOperationException("Stack is empty");
        return _collection[^1];
    }

    public bool TryPick(out T value)
    {
        if (_collection.Count == 0)
        {
            value = default;
            return false;
        }
        value = _collection[^1];
        return true;
    }

    public T Pop()
    {
        var value = Pick();
        _collection.RemoveAt(_collection.Count - 1);
        return value;
    }

    public IEnumerator<T> GetEnumerator()
    {
        return new StackEnumerator(_collection);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}