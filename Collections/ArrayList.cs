namespace Collections;

public class ArrayList<T> : ICollection<T>
{
    private int _length = 0;
    private int _capacity;
    private T[] _items;

    public ArrayList(int capacity)
    {
        _capacity = capacity;
        _items = new T[capacity];
    }

    public bool Add(T item)
    {
        // array[6] -> indices e [0,6) = [0..5]
        // array[6] -> IndexOutOfBound
        // O(1)
        if (_items.Length < _capacity)
        {
            _items[_length++] = item;
            return true;
        }

        // O(n)
        _capacity *= 2;
        Array.Resize(ref _items, _capacity);
        _items[_length++] = item;
        return true;
    }

    public bool Contains(T item)
    {
        // O(n)
        for (int index = 0; index < _length; index++)
        {
            if (_items[index]!.Equals(item)) return true;
        }

        return false;
    }

    public bool Remove(T item)
    {
        int removedIndex = -1;
        // O(n)
        for (int index = 0; index < _length; index++)
        {
            if (_items[index]!.Equals(item))
            {
                removedIndex = index;
                break;
            }
        }

        if (removedIndex == -1) return false;

        _length--;
        if (removedIndex == _length - 1) return true;

        // O(n)
        for (int index = removedIndex; index < _length - 1; index++)
        {
            _items[index] = _items[index + 1];
        }

        return true;
    }
}

