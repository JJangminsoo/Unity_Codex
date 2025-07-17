using UnityEngine;

/// <summary>
/// Handles player resources such as HP, MP, and gold.
/// </summary>
public class ResourceManager : MonoBehaviour
{
    public int Gold;

    public void AddGold(int amount)
    {
        Gold += amount;
    }

    public void SpendGold(int amount)
    {
        Gold = Mathf.Max(Gold - amount, 0);
    }
}
