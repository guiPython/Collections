namespace Tests;

using Collections;

public class LinkedListTest {
    [Fact(DisplayName = "Criando uma LinkedList vazia")]
    public void ShouldCreateAnEmptyLinkedList() {
        var list = new LinkedList<int>();
        Assert.Equal(0, list.Count);
    }

    [Fact(DisplayName = "Adicionando elemento em um LinkedList vazia")]
    public void ShouldAddAnElementWhenLinkedListIsEmpty() {
        var list = new LinkedList<int>();
        var result = list.Add(10);

        Assert.True(result);
        Assert.Equal(1, list.Count);
    }

    [Fact(DisplayName = "Removendo elemento existente do LinkedList")]
    public void ShouldReturnTrueWhenRemoveAnExistentElement() {
        var list = new LinkedList<int>();
        list.Add(10);
        var result = list.Remove(10);

        Assert.True(result);
        Assert.Equal(0, list.Count);
    }

    [Fact(DisplayName = "Removendo elemento que nao existente do LinkedList")]
    public void ShouldReturnFalseWhenRemoveANonExistentElement() {
        var list = new LinkedList<int>();
        list.Add(10);
        var result = list.Remove(20);

        Assert.False(result);
        Assert.Equal(1, list.Count);
    }

    [Fact(DisplayName = "Removendo elemento de um LinkedList vazia")]
    public void ShouldReturnFalseWhenRemoveFromEmptyList() {
        var list = new LinkedList<int>();
        var result = list.Remove(20);

        Assert.False(result);
        Assert.Equal(0, list.Count);
    }

    [Fact(DisplayName = "Verificando se a LinkedList contem um elemento")]
    public void ShouldReturnTrueWhenLinkedListContainsElement() {
        var list = new LinkedList<int>();
        list.Add(10);
        var result = list.Contains(10);

        Assert.True(result);
        Assert.Equal(1, list.Count);
    }

    [Fact(DisplayName = "Verificando se a LinkedList nao contem um elemento")]
    public void ShouldReturnFalseWhenLinkedListDontContainsElement() {
        var list = new LinkedList<int>();
        list.Add(10);
        var result = list.Contains(20);

        Assert.False(result);
        Assert.Equal(1, list.Count);
    }
}