using Collections;

namespace Tests;

public class ArrayListTest
{
    [Fact]
    public void ShouldAddAnElementWhenArrayListIsEmpty()
    {
        var list = EmptyIntegerArrayList();
        var result = list.Add(1);
        Assert.True(result);
    }

    [Fact]
    public void ShouldAddAnElementWhenArrayListIsFull()
    {
        var list = FullIntegerArrayList();
        var result = list.Add(3);
        Assert.True(result);
    }

    [Fact]
    public void ShouldReturnTrueWhenRemoveAnExistentElement()
    {
        ArrayList<int> list = new(2);
        list.Add(10);
        Assert.True(list.Remove(10));
    }

    [Fact]
    public void ShouldReturnFalseWhenRemoveANonExistentElement()
    {
        ArrayList<int> list = new(2);
        list.Add(10);
        Assert.False(list.Remove(20));
    }

    [Fact]
    public void ShouldReturnFalseWhenRemoveFromEmptyList()
    {
        var list = EmptyIntegerArrayList();
        var result = list.Remove(10);
        Assert.False(result);
    }

    [Fact]
    public void ShouldReturnTrueWhenArrayListContainsElement()
    {
        Assert.True(_binaryList.Contains(0));
    }

    [Fact]
    public void ShouldReturnFalseWhenArrayListDontContainsElement()
    {
        Assert.False(_binaryList.Contains(3));
    }

    private static ArrayList<int> EmptyIntegerArrayList() => new(10);

    private static ArrayList<int> FullIntegerArrayList()
    {
        var list = new ArrayList<int>(2);
        list.Add(1);
        list.Add(2);
        return list;
    }

    private readonly ArrayList<int> _binaryList;

    public ArrayListTest()
    {
        _binaryList = new ArrayList<int>(2);
        _binaryList.Add(0);
        _binaryList.Add(1);
    }
}