using Godot;
using System;

public partial class TeladeInício : Node2D
{
	AudioStreamPlayer2D musicainicio;
	
	public override void _Ready()
	{
		musicainicio = this.GetNode<AudioStreamPlayer2D>("MusicaInicio");
	}

	public override void _Process(double delta)
	{
	}
	
	private void _on_botao_inicio_pressed()
	{
		GetTree().ChangeSceneToFile("res://Introdução.tscn");
	}
}















