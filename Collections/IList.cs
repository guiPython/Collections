namespace Collections;

public interface IList<in T> : ICollection<T> {
    int? IndexOf(T item);
    bool InsertAt(int index, T item);
    bool RemoveAt(int index);
}