using Godot;
using System;

public partial class Fase1 : Node2D
{
	
	public override void _Ready()
	{
	}

	public override void _Process(double delta)
	{
	}
	

	private void _on_timer_timeout()
	{
		GetTree().ChangeSceneToFile("res://Fase2.tscn");
	}
	
	private void _on_area_2d_body_entered(Node2D body)
	{
		GetTree().ChangeSceneToFile("res://VocePerdeu.tscn");
	}
}









