using UnityEngine;

/// <summary>
/// Quick slot for consumable items during battle.
/// </summary>
public class QuickSlot : MonoBehaviour
{
    public Item ConsumableItem;

    public void Use(Character target)
    {
        if (ConsumableItem != null && ConsumableItem.Type == ItemType.Consumable)
        {
            // Example effect: heal by value
            target.Heal(ConsumableItem.Value);
            ConsumableItem = null;
        }
    }
}
