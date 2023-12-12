namespace Collections;

public interface ICollection<in T> {
    int Count { get; }
    bool Add(T item);
    bool Remove(T item);
    bool Contains(T item);
}