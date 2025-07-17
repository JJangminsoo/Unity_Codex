using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Manages achievements and meta progression.
/// </summary>
public class AchievementManager : MonoBehaviour
{
    public List<string> CompletedAchievements = new();

    public void CompleteAchievement(string id)
    {
        if (!CompletedAchievements.Contains(id))
        {
            CompletedAchievements.Add(id);
            Debug.Log($"Achievement unlocked: {id}");
        }
    }
}
