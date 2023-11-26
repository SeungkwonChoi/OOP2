using Xunit;
using System.Text.Json;
using Assignment_3_Dan;

public class SerializationTests
{
    [Fact]
    public void SerializeAndDeserialize_List()
    {
        var list = new SinglyLinkedList();
        list.AddFirst(1);
        list.AddLast(2);

        string json = JsonSerializer.Serialize(list);
        var deserializedList = JsonSerializer.Deserialize<SinglyLinkedList>(json);

        Assert.Equal(1, deserializedList.GetItemAt(0));
        Assert.Equal(2, deserializedList.GetItemAt(1));
    }
}
