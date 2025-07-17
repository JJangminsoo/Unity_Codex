using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Manages high level UI panels.
/// </summary>
public class UIController : MonoBehaviour
{
    public GameObject InventoryPanel;
    public GameObject BattlePanel;
    public Text HpText;

    public void UpdateHp(int hp)
    {
        if (HpText != null)
        {
            HpText.text = $"HP: {hp}";
        }
    }

    public void ToggleInventory(bool show)
    {
        if (InventoryPanel != null)
        {
            InventoryPanel.SetActive(show);
        }
    }
}
