/*using Godot;
using System;

public partial class Cartas : Node
{
	public SetCartasAmbiente()
	{
		Carta1Sprite.Frame = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 61, 62 };
		Carta2Sprite.Frame = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 61, 62 };
		Carta3Sprite.Frame = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 61, 62 };
		Carta4Sprite.Frame = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 61, 62 };
		
		valoresCartas.Add("1", -1);
		valoresCartas.Add("2", -1);
		valoresCartas.Add("3", -1);
		valoresCartas.Add("4", -1);
		
		valoresCartas.Add("1", -2);
		valoresCartas.Add("2", -2);
		valoresCartas.Add("3", -2);
		valoresCartas.Add("4", -2);
		
		valoresCartas.Add("1", -3);
		valoresCartas.Add("2", -3);
		valoresCartas.Add("3", -3);
		valoresCartas.Add("4", -3);
		
		valoresCartas.Add("61",+2);
		valoresCartas.Add("62",+2);
	}
	
	public SetCartasSeguranca()
	{
		Carta1Sprite.Frame = new int[] { 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 63, 64 };
		Carta2Sprite.Frame = new int[] { 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 63, 64 };
		Carta3Sprite.Frame = new int[] { 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 63, 64 };
		Carta4Sprite.Frame = new int[] { 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 63, 64 };
		
		valoresCartas.Add("13", -1);
		valoresCartas.Add("14", -1);
		valoresCartas.Add("15", -1);
		valoresCartas.Add("16", -1);
		
		valoresCartas.Add("17", -2);
		valoresCartas.Add("18", -2);
		valoresCartas.Add("19", -2);
		valoresCartas.Add("20", -2);
		
		valoresCartas.Add("21", -3);
		valoresCartas.Add("22", -3);
		valoresCartas.Add("23", -3);
		valoresCartas.Add("24", -3);
		
		valoresCartas.Add("63",+2);
		valoresCartas.Add("64",+2);
	}
	
	public SetCartasEnsino()
	{
		Carta1Sprite.Frame = new int[] { 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 65, 66 };
		Carta2Sprite.Frame = new int[] { 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 65, 66 };
		Carta3Sprite.Frame = new int[] { 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 65, 66 };
		Carta4Sprite.Frame = new int[] { 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 65, 66 };
		
		valoresCartas.Add("25", -1);
		valoresCartas.Add("26", -1);
		valoresCartas.Add("27", -1);
		valoresCartas.Add("28", -1);
		
		valoresCartas.Add("29", -2);
		valoresCartas.Add("30", -2);
		valoresCartas.Add("31", -2);
		valoresCartas.Add("32", -2);
		
		valoresCartas.Add("33", -3);
		valoresCartas.Add("34", -3);
		valoresCartas.Add("35", -3);
		valoresCartas.Add("36", -3);
		
		valoresCartas.Add("65",+2);
		valoresCartas.Add("66",+2);
	}
	
	public SetCartasSaude()
	{
		Carta1Sprite.Frame = new int[] { 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 67, 68 };
		Carta2Sprite.Frame = new int[] { 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 67, 68 };
		Carta3Sprite.Frame = new int[] { 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 67, 68 };
		Carta4Sprite.Frame = new int[] { 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 67, 68 };
		
		valoresCartas.Add("37", -1);
		valoresCartas.Add("38", -1);
		valoresCartas.Add("39", -1);
		valoresCartas.Add("40", -1);
		
		valoresCartas.Add("41", -2);
		valoresCartas.Add("42", -2);
		valoresCartas.Add("43", -2);
		valoresCartas.Add("44", -2);
		
		valoresCartas.Add("45", -3);
		valoresCartas.Add("46", -3);
		valoresCartas.Add("47", -3);
		valoresCartas.Add("48", -3);
		
		valoresCartas.Add("67",+2);
		valoresCartas.Add("68",+2);
	}
	
	public SetCartasTransporte()
	{
		Carta1Sprite.Frame = new int[] { 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 69, 70 };
		Carta2Sprite.Frame = new int[] { 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 69, 70 };
		Carta3Sprite.Frame = new int[] { 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 69, 70 };
		Carta4Sprite.Frame = new int[] { 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 69, 70 };
		
		valoresCartas.Add("49", -1);
		valoresCartas.Add("50", -1);
		valoresCartas.Add("51", -1);
		valoresCartas.Add("52", -1);
		
		valoresCartas.Add("53", -2);
		valoresCartas.Add("54", -2);
		valoresCartas.Add("55", -2);
		valoresCartas.Add("56", -2);
		
		valoresCartas.Add("57", -3);
		valoresCartas.Add("58", -3);
		valoresCartas.Add("59", -3);
		valoresCartas.Add("60", -3);
		
		valoresCartas.Add("69",+2);
		valoresCartas.Add("70",+2);
	}
	
	static void Main()
	{
		Cartas cartas = new Cartas();
		cartas.SetCartasAmbiente();
		cartas.SetCartasSeguranca();
		cartas.SetCartasEnsino();
		cartas.SetCartasSaude();
		cartas.SetCartasTransporte();
	}
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
*/
