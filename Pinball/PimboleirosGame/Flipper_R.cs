using Godot;
using System;

public partial class Flipper_R : Sprite2D
{
	private float rot = 0.3f;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (rot >= 0.3f)
		{
			rot = 0.3f;
		}

		if (rot <= -0.3f)
		{
			rot = -0.3f;
		}

		if (Input.IsActionPressed("left_flipper"))
		{
			rot -= 0.06f;
		}

		else
		{
			rot += 0.06f;
		}

		Rotation = rot;
	}
}
