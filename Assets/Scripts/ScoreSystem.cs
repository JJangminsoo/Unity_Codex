using UnityEngine;

/// <summary>
/// Calculates score based on gameplay performance.
/// </summary>
public class ScoreSystem : MonoBehaviour
{
    public int Score { get; private set; }

    public void ResetScore()
    {
        Score = 0;
    }

    public void AddKill(int value)
    {
        Score += value;
    }

    public void FloorCleared(int floor)
    {
        Score += floor * 100;
    }
}
