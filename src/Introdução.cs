using Godot;
using System;

public partial class Introdução : Node2D
{
	string [] frasesIntrodução = new string [6];
	int posIntrodução = 0;
	string [] imagensIntroducao = new string [6];
	public int posimagensIntroducao = 0;
	RichTextLabel texto;
	RichTextLabel texto2;
	Sprite2D imagem;
	public String textojornal;
	Sprite2D jornal;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		GetNode<LineEdit>("LineEdit").Hide();
		GetNode<Sprite2D>("NewPiskel2").Hide();
		GetNode<Sprite2D>("NewPiskel").Hide();
		this.GetNode<RichTextLabel>("RichTextLabel2");
		texto = this.GetNode<RichTextLabel>("RichTextLabel");
		imagem = this.GetNode<Sprite2D>("NewPiskel");
		texto2 = this.GetNode<RichTextLabel>("Label");
		texto2.Hide();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (posimagensIntroducao == 1)
		{
			texto2.Show();
			GetNode<LineEdit>("LineEdit").Hide();
			GetNode<Sprite2D>("NewPiskel").Hide();
			GetNode<Sprite2D>("NewPiskel2").Show();
			texto.Position = new Vector2 (416, 147);
			texto.Text = "[fill][b][color=black]"+textojornal + " ganhou as eleições!!![/color][/b][/fill]";
			texto2.Text = "[center](aperte ENTER para continuar)[/center]";
		}
		
		if (Input.IsActionJustPressed("ui_accept"))
		{
			posimagensIntroducao++;
		}
		
		if (posimagensIntroducao == 3)
		{
			if (Input.IsActionJustPressed("ui_accept"))
			{
				GetTree().ChangeSceneToFile("res://TeladeFases.tscn");
			}
		}
		
	}
	
	private void _on_line_edit_text_submitted(string new_text)
	{
		if (new_text != "")
		{
			posimagensIntroducao++;
		}
		else 
		{
		}
		textojornal = new_text;
	}
	
	private void _on_animation_player_animation_finished(StringName anim_name)
	{
		texto.Text = "[center]Para finalizar, assine sua candidatura:[/center]";
		GetNode<Sprite2D>("NewPiskel").Show();
		GetNode<RichTextLabel>("Label").Show();
		GetNode<LineEdit>("LineEdit").Show();
		texto2.Text = "[center](aperte ENTER para continuar)[/center]";
	}
}












