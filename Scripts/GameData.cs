using Godot;
using System;

/// <summary>
/// Global game data that should persist between scenes
/// </summary>
public class GameData : Node
{
    /// <summary>
    /// Index for spawn point array in a level
    /// </summary>
    public static int SpawnPointIndex { get; set; }

    /// <summary>
    /// Direction to face the player sprite when spawning
    /// </summary>
    public static int SpawnDirection { get; set; }
}
