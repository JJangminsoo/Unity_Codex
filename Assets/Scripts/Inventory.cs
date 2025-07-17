using System.Collections.Generic;

/// <summary>
/// Simple inventory to hold items.
/// </summary>
public class Inventory
{
    public List<Item> Items = new();

    public void Add(Item item)
    {
        Items.Add(item);
    }

    public void Remove(Item item)
    {
        Items.Remove(item);
    }
}
