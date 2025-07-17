using UnityEngine;

/// <summary>
/// Handles random events that occur during exploration.
/// </summary>
public class EventManager : MonoBehaviour
{
    public void TriggerRandomEvent(Character character)
    {
        int roll = Random.Range(0, 2);
        if (roll == 0)
        {
            Debug.Log("Found treasure!");
        }
        else
        {
            Debug.Log("Encountered a trap!");
            character.TakeDamage(10);
        }
    }
}
