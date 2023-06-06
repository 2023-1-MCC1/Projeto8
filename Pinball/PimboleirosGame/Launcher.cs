using Godot;
using System;

public partial class Launcher : Polygon2D
{
	private float pos_x;
	private float pos_y;

	private float push = 0.0f;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		pos_x = Position.X;
		pos_y = Position.Y;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (push >= 13.0f)
		{
			push = 13.0f;
		}
		if (push <= -13.0f)
		{
			push = -13.0f;
		}

		if (Input.IsActionPressed("launch"))
		{
			push += 13.0f;
			Position = new(pos_x, pos_y - push);
		}
		else
		{
			push -= 13.0f;
			Position = new(pos_x, pos_y - push);
		}
	}
}
