using Godot;
using System;

public partial class TeladeFases : Node2D
{
	AnimationPlayer Area1, Area2, Area3;
	bool entrou1, entrou2, entrou3;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Area1 = this.GetNode<AnimationPlayer>("Fase1");
		Area2 = this.GetNode<AnimationPlayer>("Fase2");
		Area3 = this.GetNode<AnimationPlayer>("Fase3");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	
	private void _on_botao_fase_1_pressed()
	{
		GetTree().ChangeSceneToFile("res://Inicio.tscn");
	}
	
	private void _on_botao_fase_2_pressed()
	{
		GetTree().ChangeSceneToFile("res://Inicio.tscn");
	}
	
	private void _on_botao_fase_3_pressed()
	{
		GetTree().ChangeSceneToFile("res://Inicio.tscn");
	}
	
	private void _on_botao_fase_1_mouse_entered()
	{
		Area1.Play("Fase1");
	}
	
	private void _on_botao_fase_1_mouse_exited()
	{
		Area1.Stop();
	}
	
	private void _on_botao_fase_2_mouse_entered()
	{
		Area2.Play("Fase2");
	}
	
	private void _on_botao_fase_2_mouse_exited()
	{
		Area2.Stop();
	}
	
	private void _on_botao_fase_3_mouse_entered()
	{
		Area3.Play("Fase3");
	}
	
	private void _on_botao_fase_3_mouse_exited()
	{
		Area3.Stop();
	}
	
}






































