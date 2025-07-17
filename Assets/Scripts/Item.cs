using UnityEngine;

public enum ItemType
{
    Equipment,
    Consumable,
    Special
}

/// <summary>
/// Base item definition.
/// </summary>
[System.Serializable]
public class Item
{
    public string Name;
    public ItemType Type;
    public int Value;
}
