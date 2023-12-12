namespace Collections;

///<summary>
///Representa a colecao <c>ArrayList</c>
///</summary>
public class ArrayList<T> : IList<T> {
    private int _capacity;
    private T[] _items;
    public int Count { get; private set; }

    /// <summary>
    /// Constroi um <c>ArrayList</c>
    /// <param name="capacity"> A capacidade do array interno do ArrayList </param>
    /// </summary>
    public ArrayList(int capacity) {
        Count = 0;
        _capacity = capacity;
        _items = new T[capacity];
    }

    ///<summary>
    ///<para>O metodo <c>Add</c> adiciona um item no final do ArrayList.</para>
    ///<para>O(1): Caso o ArrayList nao esteja cheio.</para>
    ///<para>O(n): Caso o ArrayList precise ser redimensionado.</para>
    ///<param name="item">O item que sera adicionado.</param>
    ///</summary>
    ///<returns>true caso o item seja adicionado, falso caso nao.</returns>
    public bool Add(T item) {
        if (Count < _capacity) {
            _items[Count++] = item;
            return true;
        }

        _capacity *= 2;
        Array.Resize(ref _items, _capacity);
        _items[Count++] = item;
        return true;
    }

    ///<summary>
    ///<para>O metodo <c>InsertAt</c> adiciona um item no ArrayList na posicao desejada.</para>
    ///<para>O(1): Sempre.</para>
    ///<param name="index">O indice que vamos modificar.</param>
    ///<param name="item">O item que sera adicionado.</param>
    ///</summary>
    ///<returns>true caso o item seja inserido, falso caso nao.</returns>
    public bool InsertAt(int index, T item) {
        if (index < _capacity) {
            _items[index] = item;
            return true;
        }

        return false;
    }

    ///<summary>
    ///<para>O metodo <c>IndexOf</c> retorna qual o indice do elemento desejado.</para>
    ///<para>O(n): Precisamos percorrer o array por completo.</para>
    ///<param name="item">O item que queremos saber o indice.</param>
    ///</summary>
    ///<returns>int indice caso o elemento exista, null caso nao.</returns>
    public int? IndexOf(T item) {
        for (int index = 0; index < Count; index++) {
            if (_items[index]!.Equals(item)) {
                return index;
            }
        }

        return null;
    }

    ///<summary>
    ///<para>O metodo <c>RemoveAt</c> remove um item do ArrayList na posicao desejada.</para>
    ///<para>O(1): Caso seja removido o ultimo elemento.</para>
    ///<para>O(n): Caso seja removido elementos em indices menores que n-1.</para>
    ///<param name="index">O indice que queremos remover.</param>
    ///</summary>
    ///<returns>true caso seja removido e false caso nao.</returns>
    public bool RemoveAt(int index) {
        if (index == _capacity - 1) {
            Count--;
            return true;
        }

        for (int i = index; index < _capacity - 1; index++) {
            _items[index] = _items[index + 1];
        }

        Count--;
        return true;
    }

    ///<summary>
    ///<para>O metodo <c>Remove</c> remove um item do ArrayList.</para>
    ///<para>O(n): Para qualquer elemento.</para>
    ///<param name="item">O item que queremos remover.</param>
    ///</summary>
    ///<returns>true caso seja removido e false caso nao.</returns>
    public bool Remove(T item) {
        int? index = IndexOf(item);

        if (index == null) return false;
        return RemoveAt(index.Value);
    }

    ///<summary>
    ///<para>O metodo <c>Contains</c> que nos diz se um elemento esta ou nao no ArrayList.</para>
    ///<para>O(n): Para qualquer elemento.</para>
    ///<param name="item">O item que queremos verificar.</param>
    ///</summary>
    ///<returns>true caso esteja no ArrayList e false caso nao.</returns>
    public bool Contains(T item) {
        for (int index = 0; index < Count; index++) {
            if (_items[index]!.Equals(item)) {
                return true;
            }
        }

        return false;
    }
}

