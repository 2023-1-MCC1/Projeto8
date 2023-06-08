using Godot;
using System;

public partial class Global : Node
{
	public int pontos;
	public int score = 0;
	private int lives = 3;
	public override void _Ready()
	{
		
	
	//Engine.MaxFps = 125;
		pontos=0;
	}

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


	
	
