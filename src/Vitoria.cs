using Godot;
using System;

public partial class Vitoria : Node2D
{
	public override void _Ready()
	{
	}

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
	
	private void _on_button_pressed()
	{
		GetTree().ChangeSceneToFile("res://TeladeFases.tscn");
	}
}









