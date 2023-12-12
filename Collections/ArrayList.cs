namespace Collections;

public class ArrayList<T> : ICollection<T> {
    private int _length;
    private int _capacity;
    private T[] _items;

    public ArrayList(int capacity) {
        _length = 0;
        _capacity = capacity;
        _items = new T[capacity];
    }

    public bool Add(T item) {
        // O(1)
        if (_length < _capacity) {
            _items[_length++] = item;
            return true;
        }

        // O(n) / n = _items.Length
        _capacity *= 2;
        Array.Resize(ref _items, _capacity);
        _items[_length++] = item;
        return true;
    }

    public bool Remove(T item) {
        int removeIndex = -1;

        for (int index = 0; index < _length; index++) {
            if (_items[index]!.Equals(item)) {
                removeIndex = index;
                break;
            }
        }

        if (removeIndex == -1) return false;

        if (removeIndex == _capacity - 1) {
            _length--;
            return true;
        }

        for (int index = removeIndex; index < _capacity - 1; index++) {
            _items[index] = _items[index + 1];
        }

        _length--;
        return true;
    }

    public bool Contains(T item) {
        for (int index = 0; index < _length; index++) {
            if (_items[index]!.Equals(item)) {
                return true;
            }
        }

        return false;
    }
}

