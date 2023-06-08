using Godot;
using System;

public partial class Fases : Node2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	private void _on_button_pressed()
	{
		GetTree().ChangeSceneToFile("res://Inicio.tscn");
	}
	private void _on_button_2_pressed()
	{
		GetTree().ChangeSceneToFile("res://Game.tscn");
	}
	private void _on_button_3_pressed()
	{
		GetTree().ChangeSceneToFile("res://Fase2.tscn");
	}
	private void _on_button_4_pressed()
	{
		GetTree().ChangeSceneToFile("res://Fase3.tscn");
	}
}
