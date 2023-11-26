using Assignment_3_Dan;
using Xunit;

public class LinkedListTest
{
    [Fact]
    public void AddFirst_AddsToEmptyList()
    {
        var list = new SinglyLinkedList();
        list.AddFirst(1);
        Assert.Equal(1, list.GetItemAt(0));
    }

}
