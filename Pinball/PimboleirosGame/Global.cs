using Godot;
using System;

public partial class Global : Node2D
{
	public int score = 0;
	private int lives = 3;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		//Engine.MaxFps = 125;

	}


	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (Input.IsActionJustPressed("restart"))
		{
			score = 0;
			lives = 3;
			GetTree().ReloadCurrentScene();
		}
	}
}
