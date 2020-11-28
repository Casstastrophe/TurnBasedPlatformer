using Godot;
using Godot.Collections;
using System;

public class LevelBase : Node2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    /// <summary>
    /// Called when the node enters the scene tree for the first time.
    /// </summary>
    public override void _Ready()
    {
        SpawnPlayer();
    }

    /// <summary>
    /// 
    /// </summary>
    private void SpawnPlayer()
    {
        Godot.Collections.Array SpawnPoints = GetNode("SpawnPoints").GetChildren();
        int spawnIndex = GameData.SpawnPointIndex;

        
    }


    //  // Called every frame. 'delta' is the elapsed time since the previous frame.
    //  public override void _Process(float delta)
    //  {
    //      
    //  }
}
