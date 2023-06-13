using Godot;
using System;

public partial class GameOver : Node2D
{
	public override void _Ready()
	{
	}

	public override void _Process(double delta)
	{
	}
	
	private void _on_botao_derrota_1_pressed()
	{
		//GetTree().ChangeSceneToFile("res://Tela de Início.tscn");
		GetTree().ChangeSceneToFile("res://TeladeFases.tscn");
	}
	
	private void _on_botao_derrota_2_pressed()
	{
		GetTree().Quit();
	}
}









