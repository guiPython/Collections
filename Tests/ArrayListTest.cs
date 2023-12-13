using Collections;

namespace Tests;

public class ArrayListTest {
    [Fact(DisplayName = "Criando um ArrayList vazio")]
    public void ShouldCreateAnEmptyLinkedList() {
        var list = new ArrayList<int>(2);
        Assert.Equal(0, list.Count);
    }

    [Fact(DisplayName = "Adicionando elemento em um ArrayList vazio")]
    public void ShouldAddAnElementWhenArrayListIsEmpty() {
        var list = EmptyIntegerArrayList();
        var added = list.Add(10);
        Assert.True(added);
        Assert.Equal(1, list.Count);
    }

    [Fact(DisplayName = "Adicionando elemento em um ArrayList cheio")]
    public void ShouldAddAnElementWhenArrayListIsFull() {
        var fullList = FullIntegerArrayList();
        var added = fullList.Add(10);
        Assert.True(added);
        Assert.Equal(3, fullList.Count);
    }

    [Fact(DisplayName = "Removendo elemento existente do ArrayList")]
    public void ShouldReturnTrueWhenRemoveAnExistentElement() {
        var binaryList = BinaryList();
        var removed = binaryList.Remove(0);
        Assert.True(removed);
        Assert.Equal(1, binaryList.Count);
    }

    [Fact(DisplayName = "Removendo elemento que nao existente do ArrayList")]
    public void ShouldReturnFalseWhenRemoveANonExistentElement() {
        var binaryList = BinaryList();
        var removed = binaryList.Remove(10);
        Assert.False(removed);
        Assert.Equal(2, binaryList.Count);
    }

    [Fact(DisplayName = "Removendo elemento de um ArrayList vazio")]
    public void ShouldReturnFalseWhenRemoveFromEmptyList() {
        var empyList = EmptyIntegerArrayList();
        var removed = empyList.Remove(10);
        Assert.False(removed);
        Assert.Equal(0, empyList.Count);
    }

    [Fact(DisplayName = "Verificando se o ArrayList contem um elemento")]
    public void ShouldReturnTrueWhenArrayListContainsElement() {
        var binaryList = BinaryList();
        var contains = binaryList.Contains(0);
        Assert.True(contains);
        Assert.Equal(2, binaryList.Count);
    }

    [Fact(DisplayName = "Verificando se o ArrayList nao contem um elemento")]
    public void ShouldReturnFalseWhenArrayListDontContainsElement() {
        var binaryList = BinaryList();
        var contains = binaryList.Contains(3);
        Assert.False(contains);
        Assert.Equal(2, binaryList.Count);
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