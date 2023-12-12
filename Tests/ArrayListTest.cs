using Collections;

namespace Tests;

public class ArrayListTest {
    [Fact]
    public void ShouldAddAnElementWhenArrayListIsEmpty() {
        var emptyList = EmptyIntegerArrayList();
        var added = emptyList.Add(10);
        Assert.True(added);
    }

    [Fact]
    public void ShouldAddAnElementWhenArrayListIsFull() {
        var fullList = FullIntegerArrayList();
        var added = fullList.Add(10);
        Assert.True(added);
    }

    [Fact]
    public void ShouldReturnTrueWhenRemoveAnExistentElement() {
        var binaryList = BinaryList();
        var removed = binaryList.Remove(0);
        Assert.True(removed);
    }

    [Fact]
    public void ShouldReturnFalseWhenRemoveANonExistentElement() {
        var binaryList = BinaryList();
        var removed = binaryList.Remove(10);
        Assert.False(removed);
    }

    [Fact]
    public void ShouldReturnFalseWhenRemoveFromEmptyList() {
        var binaryList = EmptyIntegerArrayList();
        var removed = binaryList.Remove(10);
        Assert.False(removed);
    }

    [Fact]
    public void ShouldReturnTrueWhenArrayListContainsElement() {
        var binaryList = BinaryList();
        var contains = binaryList.Contains(0);
        Assert.True(contains);
    }

    [Fact]
    public void ShouldReturnFalseWhenArrayListDontContainsElement() {
        var binaryList = BinaryList();
        var contains = binaryList.Contains(3);
        Assert.False(contains);
    }

    private static ArrayList<int> EmptyIntegerArrayList() => new(capacity: 2);

    private static ArrayList<int> FullIntegerArrayList() {
        var list = new ArrayList<int>(capacity: 2);
        list.Add(1);
        list.Add(2);
        return list;
    }

    private static ArrayList<int> BinaryList() {
        var list = new ArrayList<int>(capacity: 2);
        list.Add(0);
        list.Add(1);
        return list;
    }
}