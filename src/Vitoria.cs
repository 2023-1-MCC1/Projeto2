using Godot;
using System;

public partial class Vitoria : Node2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	
	private void _on_botao_vitoria_1_pressed()
	{
		GetTree().ChangeSceneToFile("res://TeladeFases.tscn");
	}
	
	private void _on_botao_vitoria_2_pressed()
	{
		GetTree().Quit();
	}
}






