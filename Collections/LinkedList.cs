namespace Collections;

///<summary>
///Representa a colecao <c>LinkedList</c>
///</summary>
public class LinkedList<T> : IList<T> where T : notnull {
    ///<summary>
    ///Representa um elemento de uma <c>LinkedList</c>
    ///</summary>
    private sealed class Element(T item, Element? next) {
        public T Item = item;
        public Element? Next = next;
        public static Element Of(T item) => new(item, null);
        public static Element With(T item, Element next) => new(item, next);

        public override int GetHashCode() => Item.GetHashCode();

        private bool EqualsCasted(Element other) => Item.Equals(other.Item);

        public bool Equals(Element? other) => other is not null && EqualsCasted(other);
    }

    private Element? _head;
    public int Count { get; private set; }

    ///<summary>
    ///<para>O metodo <c>Add</c> adiciona um item no final da LinkedList.</para>
    ///<para>Analise assitotica O(n).</para>
    ///<param name="item">O item que sera adicionado.</param>
    ///</summary>
    ///<returns>true caso o item seja adicionado, falso caso nao.</returns>
    public bool Add(T item) {
        if (Count == 0) {
            _head = Element.Of(item);
            Count++;
            return true;
        }

        var element = _head;
        while (element!.Next != null) element = element.Next;

        element.Next = Element.Of(item);
        Count++;
        return true;
    }

    ///<summary>
    ///<para>O metodo <c>Remove</c> remove um item da LinkedList.</para>
    ///<para>O(n): Para qualquer elemento.</para>
    ///<param name="item">O item que queremos remover.</param>
    ///</summary>
    ///<returns>true caso seja removido e false caso nao.</returns>
    public bool Remove(T item) {
        if (Count == 0) return false;
        var indexOfItem = IndexOf(item);
        return indexOfItem.HasValue && RemoveAt(indexOfItem.Value);
    }

    ///<summary>
    ///<para>O metodo <c>Contains</c> que nos diz se um elemento esta ou nao na LinkedList.</para>
    ///<para>O(n): Para qualquer elemento.</para>
    ///<param name="item">O item que queremos verificar.</param>
    ///</summary>
    ///<returns>true caso esteja na LinkedList e false caso nao.</returns>
    public bool Contains(T item) {
        if (Count == 0) return false;
        var element = _head;
        while (element is not null) {
            if (element.Item.Equals(item)) return true;
            element = element.Next;
        }

        return false;
    }

    ///<summary>
    ///<para>O metodo <c>IndexOf</c> retorna qual o indice do elemento desejado.</para>
    ///<para>O(n): Precisamos percorrer a lista por completo.</para>
    ///<param name="item">O item que queremos saber o indice.</param>
    ///</summary>
    ///<returns>int indice caso o elemento exista, null caso nao.</returns>
    public int? IndexOf(T item) {
        if (Count == 0) return null;

        var index = 0;
        var element = _head;
        while (element is not null) {
            if (element.Item.Equals(item)) return index;
            element = element.Next;
            index++;
        }

        return null;
    }

    ///<summary>
    ///<para>O metodo <c>InsertAt</c> adiciona um item na LinkedList na posicao desejada.</para>
    ///<para>O(n): Sempre.</para>
    ///<param name="index">O indice que vamos modificar.</param>
    ///<param name="item">O item que sera adicionado.</param>
    ///</summary>
    ///<returns>true caso o item seja inserido, falso caso nao.</returns>
    public bool InsertAt(int index, T item) {
        Element? next;
        if (index == 0) {
            next = _head;
            _head = Element.With(item, next);
            Count++;
            return true;
        }

        var aux = 0;
        var element = _head;
        while (aux < index) {
            element = element.Next;
            aux++;
        }

        next = element.Next;
        element.Next = Element.With(item, next);
        Count++;
        return true;
    }

    ///<summary>
    ///<para>O metodo <c>RemoveAt</c> remove um item da LinkedList na posicao desejada.</para>
    ///<para>O(n): Caso seja removido elementos em indices menores que n-1.</para>
    ///<param name="index">O indice que queremos remover.</param>
    ///</summary>
    ///<returns>true caso seja removido e false caso nao.</returns>
    public bool RemoveAt(int index) {
        if (Count == 0 || index >= Count) return false;

        if (index == 0) {
            _head = _head?.Next;
            Count--;
            return true;
        }

        var aux = 0;
        var element = _head;
        while (aux < index) {
            element = element.Next;
            aux++;
        }

        var next = element?.Next?.Next;
        element!.Next = next;
        Count--;
        return true;
    }
}