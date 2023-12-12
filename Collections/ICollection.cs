namespace Collections;

public interface ICollection<in T> {
    bool Add(T item);
    bool Remove(T item);
    bool Contains(T item);
}