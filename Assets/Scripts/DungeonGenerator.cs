using System.Collections.Generic;
using UnityEngine;

public enum RoomType
{
    Battle,
    Event,
    Treasure,
    Shop,
    Boss
}

/// <summary>
/// Generates procedural dungeon floors.
/// </summary>
public class DungeonGenerator : MonoBehaviour
{
    public int RoomsPerFloor = 5;

    public List<RoomType> GenerateFloor()
    {
        List<RoomType> floor = new();
        for (int i = 0; i < RoomsPerFloor; i++)
        {
            RoomType type = (RoomType)Random.Range(0, 4); // boss not generated until end
            floor.Add(type);
        }
        floor.Add(RoomType.Boss);
        return floor;
    }
}
