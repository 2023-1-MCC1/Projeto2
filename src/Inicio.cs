using Godot;
using System;

public partial class Inicio : Node
{
	public Sprite2D Moeda1Sprite, Moeda2Sprite, Moeda3Sprite, Moeda4Sprite, Carta1Sprite, Carta2Sprite, Carta3Sprite, Carta4Sprite;
	public static int Moeda1, Moeda2, Moeda3, Moeda4, Carta1, Carta2, Carta3, Carta4, Conta1, Conta2, Conta3, Conta4, Setor0, Setor1, Setor2, Setor3, usado, valorbotao1, valorbotao2, valorbotao3, valorbotao4, jogadas;
	public bool preenchido1 = false;
	public bool preenchido2 = false;
	public bool preenchido3 = false;
	public bool preenchido4 = false;
	public bool usado1 = false;
	public bool usado2 = false;
	public bool usado3 = false;
	public bool usado4 = false;
	Vector2 posicao1, posicao2, posicao3, posicao4;
	Button avancar;
	bool vez = true;
	int count = 0;
	int moeda1, moeda2, moeda3, moeda4;
	public AnimationPlayer Flip1, Flip2, Flip3, Flip4;
	public int [] listamoedas = new int[4];
	/*public int [] setoressorteados = new int[4]
	{
		setoressorteados[0] = Setor0,
		setoressorteados[1] = Setor1,
		setoressorteados[2] = Setor2,
		setoressorteados[3] = Setor3,
	};*/
	public static int[,,] matrizTridimensionalcartas = new int [4, 4, 56];
	public static Random rnd = new Random();
	
	public static int Saudecurrent_health = 5;
	public static int Saudemax_health=10;

	public static int Ambientecurrent_health=5;
	public static int Ambientemax_health=10;

	public static int Segurancacurrent_health=5;
	public static int Segurancamax_health=10;
	
	public static int Ensinocurrent_health=5;
	public static int Ensinomax_health=10;
	
	public void set_healthSaude (ProgressBar BarraSaude, int Saudemax_health, int Saudecurrent_health)
		{
			BarraSaude.Value = Saudecurrent_health;
			BarraSaude.MaxValue = Saudemax_health;
		}
		
	public void set_healthEnsino (ProgressBar BarraEnsino, int Ensinomax_health, int Ensinocurrent_health)
		{
			BarraEnsino.Value = Ensinocurrent_health;
			BarraEnsino.MaxValue = Ensinomax_health;
		}
		
	public void set_healthSeguranca (ProgressBar BarraSeguranca, int Segurancamax_health, int Segurancacurrent_health)
		{
			BarraSeguranca.Value = Segurancacurrent_health;
			BarraSeguranca.MaxValue = Segurancamax_health;
		}
		
	public void set_healthAmbiente (ProgressBar BarraAmbiente, int Ambientemax_health, int Ambientecurrent_health)
		{
			BarraAmbiente.Value = Ambientecurrent_health;
			BarraAmbiente.MaxValue = Ambientemax_health;
		}
	
	public static void sorteios()
	{
		Carta1 = rnd.Next(0,14);
		//GD.Print("Carta 1: " + Carta1);
		Carta2 = rnd.Next(14,28);
		//GD.Print("Carta 2: " + Carta2);
		Carta3 = rnd.Next(28,42);
		//GD.Print("Carta 3: " + Carta3);
		Carta4 = rnd.Next(42,56);
		//GD.Print("Carta 4: " + Carta4);
		Moeda1 = rnd.Next(0,4);
		//GD.Print("Moeda 1: " + Moeda1);
		Moeda2 = rnd.Next(0,4);
		//GD.Print("Moeda 2: " + Moeda2);
		Moeda3 = rnd.Next(0,4);
		//GD.Print("Moeda 3: " + Moeda3);
		Moeda4 = rnd.Next(0,4);
		//GD.Print("Moeda 4: " + Moeda4);
	}
	
	public static void matriz()
	{
			matrizTridimensionalcartas [0,0,0] = -3;
			matrizTridimensionalcartas [0,0,1] = -3;
			matrizTridimensionalcartas [0,0,2] = -3;
			matrizTridimensionalcartas [0,0,3] = -3;
			matrizTridimensionalcartas [0,0,4] = -2;
			matrizTridimensionalcartas [0,0,5] = -2;
			matrizTridimensionalcartas [0,0,6] = -2;
			matrizTridimensionalcartas [0,0,7] = -2;
			matrizTridimensionalcartas [0,0,8] = -1;
			matrizTridimensionalcartas [0,0,9] = -1;
			matrizTridimensionalcartas [0,0,10] = -1;
			matrizTridimensionalcartas [0,0,11] = -1;
			matrizTridimensionalcartas [0,0,12] = +2;
			matrizTridimensionalcartas [0,0,13] = +2;
			matrizTridimensionalcartas [1,0,14] = -3;
			matrizTridimensionalcartas [1,0,15] = -3;
			matrizTridimensionalcartas [1,0,16] = -3;
			matrizTridimensionalcartas [1,0,17] = -3;
			matrizTridimensionalcartas [1,0,18] = -2;
			matrizTridimensionalcartas [1,0,19] = -2;
			matrizTridimensionalcartas [1,0,20] = -2;
			matrizTridimensionalcartas [1,0,21] = -2;
			matrizTridimensionalcartas [1,0,22] = -1;
			matrizTridimensionalcartas [1,0,23] = -1;
			matrizTridimensionalcartas [1,0,24] = -1;
			matrizTridimensionalcartas [1,0,25] = -1;
			matrizTridimensionalcartas [1,0,26] = +2;
			matrizTridimensionalcartas [1,0,27] = +2;
			matrizTridimensionalcartas [2,0,28] = -3;
			matrizTridimensionalcartas [2,0,29] = -3;
			matrizTridimensionalcartas [2,0,30] = -3;
			matrizTridimensionalcartas [2,0,31] = -3;
			matrizTridimensionalcartas [2,0,32] = -2;
			matrizTridimensionalcartas [2,0,33] = -2;
			matrizTridimensionalcartas [2,0,34] = -2;
			matrizTridimensionalcartas [2,0,35] = -2;
			matrizTridimensionalcartas [2,0,36] = -1;
			matrizTridimensionalcartas [2,0,37] = -1;
			matrizTridimensionalcartas [2,0,38] = -1;
			matrizTridimensionalcartas [2,0,39] = -1;
			matrizTridimensionalcartas [2,0,40] = +2;
			matrizTridimensionalcartas [2,0,41] = +2;
			matrizTridimensionalcartas [3,0,42] = -3;
			matrizTridimensionalcartas [3,0,43] = -3;
			matrizTridimensionalcartas [3,0,44] = -3;
			matrizTridimensionalcartas [3,0,45] = -3;
			matrizTridimensionalcartas [3,0,46] = -2;
			matrizTridimensionalcartas [3,0,47] = -2;
			matrizTridimensionalcartas [3,0,48] = -2;
			matrizTridimensionalcartas [3,0,49] = -2;
			matrizTridimensionalcartas [3,0,50] = -1;
			matrizTridimensionalcartas [3,0,51] = -1;
			matrizTridimensionalcartas [3,0,52] = -1;
			matrizTridimensionalcartas [3,0,53] = -1;
			matrizTridimensionalcartas [3,0,54] = +2;
			matrizTridimensionalcartas [3,0,55] = +2;
			
			
			matrizTridimensionalcartas [0,1,0] = -3;
			matrizTridimensionalcartas [0,1,1] = -3;
			matrizTridimensionalcartas [0,1,2] = -3;
			matrizTridimensionalcartas [0,1,3] = -3;
			matrizTridimensionalcartas [0,1,4] = -2;
			matrizTridimensionalcartas [0,1,5] = -2;
			matrizTridimensionalcartas [0,1,6] = -2;
			matrizTridimensionalcartas [0,1,7] = -2;
			matrizTridimensionalcartas [0,1,8] = -1;
			matrizTridimensionalcartas [0,1,9] = -1;
			matrizTridimensionalcartas [0,1,10] = -1;
			matrizTridimensionalcartas [0,1,11] = -1;
			matrizTridimensionalcartas [0,1,12] = +2;
			matrizTridimensionalcartas [0,1,13] = +2;
			matrizTridimensionalcartas [1,1,14] = -3;
			matrizTridimensionalcartas [1,1,15] = -3;
			matrizTridimensionalcartas [1,1,16] = -3;
			matrizTridimensionalcartas [1,1,17] = -3;
			matrizTridimensionalcartas [1,1,18] = -2;
			matrizTridimensionalcartas [1,1,19] = -2;
			matrizTridimensionalcartas [1,1,20] = -2;
			matrizTridimensionalcartas [1,1,21] = -2;
			matrizTridimensionalcartas [1,1,22] = -1;
			matrizTridimensionalcartas [1,1,23] = -1;
			matrizTridimensionalcartas [1,1,24] = -1;
			matrizTridimensionalcartas [1,1,25] = -1;
			matrizTridimensionalcartas [1,1,26] = +2;
			matrizTridimensionalcartas [1,1,27] = +2;
			matrizTridimensionalcartas [2,1,28] = -3;
			matrizTridimensionalcartas [2,1,29] = -3;
			matrizTridimensionalcartas [2,1,30] = -3;
			matrizTridimensionalcartas [2,1,31] = -3;
			matrizTridimensionalcartas [2,1,32] = -2;
			matrizTridimensionalcartas [2,1,33] = -2;
			matrizTridimensionalcartas [2,1,34] = -2;
			matrizTridimensionalcartas [2,1,35] = -2;
			matrizTridimensionalcartas [2,1,36] = -1;
			matrizTridimensionalcartas [2,1,37] = -1;
			matrizTridimensionalcartas [2,1,38] = -1;
			matrizTridimensionalcartas [2,1,39] = -1;
			matrizTridimensionalcartas [2,1,40] = +2;
			matrizTridimensionalcartas [2,1,41] = +2;
			matrizTridimensionalcartas [3,1,42] = -3;
			matrizTridimensionalcartas [3,1,43] = -3;
			matrizTridimensionalcartas [3,1,44] = -3;
			matrizTridimensionalcartas [3,1,45] = -3;
			matrizTridimensionalcartas [3,1,46] = -2;
			matrizTridimensionalcartas [3,1,47] = -2;
			matrizTridimensionalcartas [3,1,48] = -2;
			matrizTridimensionalcartas [3,1,49] = -2;
			matrizTridimensionalcartas [3,1,50] = -1;
			matrizTridimensionalcartas [3,1,51] = -1;
			matrizTridimensionalcartas [3,1,52] = -1;
			matrizTridimensionalcartas [3,1,53] = -1;
			matrizTridimensionalcartas [3,1,54] = +2;
			matrizTridimensionalcartas [3,1,55] = +2;
			
			matrizTridimensionalcartas [0,2,0] = -3;
			matrizTridimensionalcartas [0,2,1] = -3;
			matrizTridimensionalcartas [0,2,2] = -3;
			matrizTridimensionalcartas [0,2,3] = -3;
			matrizTridimensionalcartas [0,2,4] = -2;
			matrizTridimensionalcartas [0,2,5] = -2;
			matrizTridimensionalcartas [0,2,6] = -2;
			matrizTridimensionalcartas [0,2,7] = -2;
			matrizTridimensionalcartas [0,2,8] = -1;
			matrizTridimensionalcartas [0,2,9] = -1;
			matrizTridimensionalcartas [0,2,10] = -1;
			matrizTridimensionalcartas [0,2,11] = -1;
			matrizTridimensionalcartas [0,2,12] = +2;
			matrizTridimensionalcartas [0,2,13] = +2;
			matrizTridimensionalcartas [1,2,14] = -3;
			matrizTridimensionalcartas [1,2,15] = -3;
			matrizTridimensionalcartas [1,2,16] = -3;
			matrizTridimensionalcartas [1,2,17] = -3;
			matrizTridimensionalcartas [1,2,18] = -2;
			matrizTridimensionalcartas [1,2,19] = -2;
			matrizTridimensionalcartas [1,2,20] = -2;
			matrizTridimensionalcartas [1,2,21] = -2;
			matrizTridimensionalcartas [1,2,22] = -1;
			matrizTridimensionalcartas [1,2,23] = -1;
			matrizTridimensionalcartas [1,2,24] = -1;
			matrizTridimensionalcartas [1,2,25] = -1;
			matrizTridimensionalcartas [1,2,26] = +2;
			matrizTridimensionalcartas [1,2,27] = +2;
			matrizTridimensionalcartas [2,2,28] = -3;
			matrizTridimensionalcartas [2,2,29] = -3;
			matrizTridimensionalcartas [2,2,30] = -3;
			matrizTridimensionalcartas [2,2,31] = -3;
			matrizTridimensionalcartas [2,2,32] = -2;
			matrizTridimensionalcartas [2,2,33] = -2;
			matrizTridimensionalcartas [2,2,34] = -2;
			matrizTridimensionalcartas [2,2,35] = -2;
			matrizTridimensionalcartas [2,2,36] = -1;
			matrizTridimensionalcartas [2,2,37] = -1;
			matrizTridimensionalcartas [2,2,38] = -1;
			matrizTridimensionalcartas [2,2,39] = -1;
			matrizTridimensionalcartas [2,2,40] = +2;
			matrizTridimensionalcartas [2,2,41] = +2;
			matrizTridimensionalcartas [3,2,42] = -3;
			matrizTridimensionalcartas [3,2,43] = -3;
			matrizTridimensionalcartas [3,2,44] = -3;
			matrizTridimensionalcartas [3,2,45] = -3;
			matrizTridimensionalcartas [3,2,46] = -2;
			matrizTridimensionalcartas [3,2,47] = -2;
			matrizTridimensionalcartas [3,2,48] = -2;
			matrizTridimensionalcartas [3,2,49] = -2;
			matrizTridimensionalcartas [3,2,50] = -1;
			matrizTridimensionalcartas [3,2,51] = -1;
			matrizTridimensionalcartas [3,2,52] = -1;
			matrizTridimensionalcartas [3,2,53] = -1;
			matrizTridimensionalcartas [3,2,54] = +2;
			matrizTridimensionalcartas [3,2,55] = +2;
			
			matrizTridimensionalcartas [0,3,0] = -3;
			matrizTridimensionalcartas [0,3,1] = -3;
			matrizTridimensionalcartas [0,3,2] = -3;
			matrizTridimensionalcartas [0,3,3] = -3;
			matrizTridimensionalcartas [0,3,4] = -2;
			matrizTridimensionalcartas [0,3,5] = -2;
			matrizTridimensionalcartas [0,3,6] = -2;
			matrizTridimensionalcartas [0,3,7] = -2;
			matrizTridimensionalcartas [0,3,8] = -1;
			matrizTridimensionalcartas [0,3,9] = -1;
			matrizTridimensionalcartas [0,3,10] = -1;
			matrizTridimensionalcartas [0,3,11] = -1;
			matrizTridimensionalcartas [0,3,12] = +2;
			matrizTridimensionalcartas [0,3,13] = +2;
			matrizTridimensionalcartas [1,3,14] = -3;
			matrizTridimensionalcartas [1,3,15] = -3;
			matrizTridimensionalcartas [1,3,16] = -3;
			matrizTridimensionalcartas [1,3,17] = -3;
			matrizTridimensionalcartas [1,3,18] = -2;
			matrizTridimensionalcartas [1,3,19] = -2;
			matrizTridimensionalcartas [1,3,20] = -2;
			matrizTridimensionalcartas [1,3,21] = -2;
			matrizTridimensionalcartas [1,3,22] = -1;
			matrizTridimensionalcartas [1,3,23] = -1;
			matrizTridimensionalcartas [1,3,24] = -1;
			matrizTridimensionalcartas [1,3,25] = -1;
			matrizTridimensionalcartas [1,3,26] = +2;
			matrizTridimensionalcartas [1,3,27] = +2;
			matrizTridimensionalcartas [2,3,28] = -3;
			matrizTridimensionalcartas [2,3,29] = -3;
			matrizTridimensionalcartas [2,3,30] = -3;
			matrizTridimensionalcartas [2,3,31] = -3;
			matrizTridimensionalcartas [2,3,32] = -2;
			matrizTridimensionalcartas [2,3,33] = -2;
			matrizTridimensionalcartas [2,3,34] = -2;
			matrizTridimensionalcartas [2,3,35] = -2;
			matrizTridimensionalcartas [2,3,36] = -1;
			matrizTridimensionalcartas [2,3,37] = -1;
			matrizTridimensionalcartas [2,3,38] = -1;
			matrizTridimensionalcartas [2,3,39] = -1;
			matrizTridimensionalcartas [2,3,40] = +2;
			matrizTridimensionalcartas [2,3,41] = +2;
			matrizTridimensionalcartas [3,3,42] = -3;
			matrizTridimensionalcartas [3,3,43] = -3;
			matrizTridimensionalcartas [3,3,44] = -3;
			matrizTridimensionalcartas [3,3,45] = -3;
			matrizTridimensionalcartas [3,3,46] = -2;
			matrizTridimensionalcartas [3,3,47] = -2;
			matrizTridimensionalcartas [3,3,48] = -2;
			matrizTridimensionalcartas [3,3,49] = -2;
			matrizTridimensionalcartas [3,3,50] = -1;
			matrizTridimensionalcartas [3,3,51] = -1;
			matrizTridimensionalcartas [3,3,52] = -1;
			matrizTridimensionalcartas [3,3,53] = -1;
			matrizTridimensionalcartas [3,3,54] = +2;
			matrizTridimensionalcartas [3,3,55] = +2;
		}
		
	public override void _Ready()
	{
		avancar = this.GetNode<Button>("CanvasLayer/Button");
	
		
		posicao1 = GetNode<Node2D>("Posicao1").Position;
		posicao2 = GetNode<Node2D>("Posicao2").Position;
		posicao3 = GetNode<Node2D>("Posicao3").Position;
		posicao4 = GetNode<Node2D>("Posicao4").Position;
		
		//sorteios();
		
		Vector2[] posicoesmoedas = new Vector2[]
		{
			new Vector2(796,85),
			new Vector2(910,85),
			new Vector2(1027.87f,85),
			new Vector2(1147.5f,85),
		};
		
		Flip1 = this.GetNode<AnimationPlayer>("Flip1");
		Flip2 = this.GetNode<AnimationPlayer>("Flip2");
		Flip3 = this.GetNode<AnimationPlayer>("Flip3");
		Flip4 = this.GetNode<AnimationPlayer>("Flip4");
		
		sorteios();
		
		listamoedas[0] = Moeda1; 
		listamoedas[1] = Moeda2;
		listamoedas[2] = Moeda3;
		listamoedas[3] = Moeda4;
		
			bool ord = true;
			while (ord)
			{
				ord = false;
				for (int i = 0; i < 3; i++)
				{
					if (listamoedas [i]<listamoedas[i+1])
					{
						int aux = listamoedas[i];
						listamoedas[i]=listamoedas[i+1];
						listamoedas[i+1]=aux;
						ord=true;
					}
				}
			}
		
		
		Moeda1Sprite = GetNode<Sprite2D>("Moeda1");
		Moeda1Sprite.Frame = listamoedas [0];
		
		Moeda2Sprite = GetNode<Sprite2D>("Moeda2");
		Moeda2Sprite.Frame = listamoedas [1];
					
		Moeda3Sprite = GetNode<Sprite2D>("Moeda3");
		Moeda3Sprite.Frame = listamoedas [2];
					
		Moeda4Sprite = GetNode<Sprite2D>("Moeda4");
		Moeda4Sprite.Frame = listamoedas [3];
					
		Carta1Sprite = GetNode<Sprite2D>("Flip1/Carta1");
		Carta1Sprite.Frame = Carta1;
					
		Carta2Sprite = GetNode<Sprite2D>("Flip2/Carta2");
		Carta2Sprite.Frame = Carta2;
					
		Carta3Sprite = GetNode<Sprite2D>("Flip3/Carta3");
		Carta3Sprite.Frame = Carta3;
					
		Carta4Sprite = GetNode<Sprite2D>("Flip4/Carta4");
		Carta4Sprite.Frame = Carta4;
		
		ProgressBar BarraSaude = GetNode <ProgressBar> ("Control/BarraSaude");
		set_healthSaude (BarraSaude, Saudemax_health, Saudecurrent_health);
		
		ProgressBar BarraAmbiente = GetNode <ProgressBar> ("Control/BarraAmbiente");
		set_healthAmbiente (BarraAmbiente, Ambientemax_health, Ambientecurrent_health);
		
		ProgressBar BarraSeguranca = GetNode <ProgressBar> ("Control/BarraSeguranca");
		set_healthSeguranca (BarraSeguranca, Segurancamax_health, Segurancacurrent_health);
		
		ProgressBar BarraEnsino = GetNode <ProgressBar> ("Control/BarraEnsino");
		set_healthEnsino (BarraEnsino, Ensinomax_health, Ensinocurrent_health); 
		
		//Carta1
		if (Carta1 == 0 || Carta1 == 1 || Carta1 == 2 || Carta1 == 3 || Carta1 == 4 || Carta1 == 5 || Carta1 == 6 || Carta1 == 7 || Carta1 == 8 || Carta1 == 9 || Carta1 == 10 || Carta1 == 11)
		{
			Setor0 = 0;
		}
		
		else if (Carta1 == 12 || Carta1 == 13 || Carta1 == 14 || Carta1 == 15 || Carta1 == 16 || Carta1 == 17 || Carta1 == 18 || Carta1 == 19 || Carta1 == 20 || Carta1 == 21 || Carta1 == 22 || Carta1 == 23)
		{
			Setor0 = 1;
		}
		
		else if (Carta1 == 24 || Carta1 == 25 || Carta1 == 26 || Carta1 == 27 || Carta1 == 28 || Carta1 == 29 || Carta1 == 30 || Carta1 == 31 || Carta1 == 32 || Carta1 == 33 || Carta1 == 34 || Carta1 == 35)
		{
			Setor0 = 2;
		}
		
		else if (Carta1 == 36 || Carta1 == 37 || Carta1 == 38 || Carta1 == 39 || Carta1 == 40 || Carta1 == 41 || Carta1 == 42 || Carta1 == 43 || Carta1 == 44 || Carta1 == 45 || Carta1 == 46 || Carta1 == 47)
		{
			Setor0 = 3;
		}
		
		else if (Carta1 == 48 || Carta1 == 49)
		{
			Setor0 = 0;
		}
		
		else if (Carta1 == 50 || Carta1 == 51)
		{
			Setor0 = 1;
		}
		
		else if (Carta1 == 52 || Carta1 == 53)
		{
			Setor0 = 2;
		}
		
		else if (Carta1 == 54 || Carta1 == 55)
		{
			Setor0 = 3;
		}
		
		//Carta2
		if (Carta2 == 0 || Carta2 == 1 || Carta2 == 2 || Carta2 == 3 || Carta2 == 4 || Carta2 == 5 || Carta2 == 6 || Carta2 == 7 || Carta2 == 8 || Carta2 == 9 || Carta2 == 10 || Carta2 == 11)
		{
			Setor1 = 0;
		}
		
		else if (Carta2 == 12 || Carta2 == 13 || Carta2 == 14 || Carta2 == 15 || Carta2 == 16 || Carta2 == 17 || Carta2 == 18 || Carta2 == 19 || Carta2 == 20 || Carta2 == 21 || Carta2 == 22 || Carta2 == 23)
		{
			Setor1 = 1;
		}
		
		else if (Carta2 == 24 || Carta2 == 25 || Carta2 == 26 || Carta2 == 27 || Carta2 == 28 || Carta2 == 29 || Carta2 == 30 || Carta2 == 31 || Carta2 == 32 || Carta2 == 33 || Carta2 == 34 || Carta2 == 35)
		{
			Setor1 = 2;
		}
		
		else if (Carta2 == 36 || Carta2 == 37 || Carta2 == 38 || Carta2 == 39 || Carta2 == 40 || Carta2 == 41 || Carta2 == 42 || Carta2 == 43 || Carta2 == 44 || Carta2 == 45 || Carta2 == 46 || Carta2 == 47)
		{
			Setor1 = 3;
		}
		
		else if (Carta2 == 48 || Carta2 == 49)
		{
			Setor1 = 0;
		}
		
		else if (Carta2 == 50 || Carta2 == 51)
		{
			Setor1 = 1;
		}
		
		else if (Carta2 == 52 || Carta2 == 53)
		{
			Setor1 = 2;
		}
		
		else if (Carta2 == 54 || Carta2 == 55)
		{
			Setor1 = 3;
		}
		
		//Carta3
		if (Carta3 == 0 || Carta3 == 1 || Carta3 == 2 || Carta3 == 3 || Carta3 == 4 || Carta3 == 5 || Carta3 == 6 || Carta3 == 7 || Carta3 == 8 || Carta3 == 9 || Carta3 == 10 || Carta3 == 11)
		{
			Setor2 = 0;
		}
		
		else if (Carta3 == 12 || Carta3 == 13 || Carta3 == 14 || Carta3 == 15 || Carta3 == 16 || Carta3 == 17 || Carta3 == 18 || Carta3 == 19 || Carta3 == 20 || Carta3 == 21 || Carta3 == 22 || Carta3 == 23)
		{
			Setor2 = 1;
		}
		
		else if (Carta3 == 24 || Carta3 == 25 || Carta3 == 26 || Carta3 == 27 || Carta3 == 28 || Carta3 == 29 || Carta3 == 30 || Carta3 == 31 || Carta3 == 32 || Carta3 == 33 || Carta3 == 34 || Carta3 == 35)
		{
			Setor2 = 2;
		}
		
		else if (Carta3 == 36 || Carta3 == 37 || Carta3 == 38 || Carta3 == 39 || Carta3 == 40 || Carta3 == 41 || Carta3 == 42 || Carta3 == 43 || Carta3 == 44 || Carta3 == 45 || Carta3 == 46 || Carta3 == 47)
		{
			Setor2 = 3;
		}
		
		else if (Carta3 == 48 || Carta3 == 49)
		{
			Setor2 = 0;
		}
		
		else if (Carta3 == 50 || Carta3 == 51)
		{
			Setor2 = 1;
		}
		
		else if (Carta3 == 52 || Carta3 == 53)
		{
			Setor2 = 2;
		}
		
		else if (Carta3 == 54 || Carta3 == 55)
		{
			Setor2 = 3;
		}
		
		//Carta4
		if (Carta4 == 0 || Carta4 == 1 || Carta4 == 2 || Carta4 == 3 || Carta4 == 4 || Carta4 == 5 || Carta4 == 6 || Carta4 == 7 || Carta4 == 8 || Carta4 == 9 || Carta4 == 10 || Carta4 == 11)
		{
			Setor3 = 0;
		}
		
		else if (Carta4 == 12 || Carta4 == 13 || Carta4 == 14 || Carta4 == 15 || Carta4 == 16 || Carta4 == 17 || Carta4 == 18 || Carta4 == 19 || Carta4 == 20 || Carta4 == 21 || Carta4 == 22 || Carta4 == 23)
		{
			Setor3 = 1;
		}
		
		else if (Carta4 == 24 || Carta4 == 25 || Carta4 == 26 || Carta4 == 27 || Carta4 == 28 || Carta4 == 29 || Carta4 == 30 || Carta4 == 31 || Carta4 == 32 || Carta4 == 33 || Carta4 == 34 || Carta4 == 35)
		{
			Setor3 = 2;
		}
		
		else if (Carta4 == 36 || Carta4 == 37 || Carta4 == 38 || Carta4 == 39 || Carta4 == 40 || Carta4 == 41 || Carta4 == 42 || Carta4 == 43 || Carta4 == 44 || Carta4 == 45 || Carta4 == 46 || Carta4 == 47)
		{
			Setor3 = 3;
		}
		
		else if (Carta4 == 48 || Carta4 == 49)
		{
			Setor3 = 0;
		}
		
		else if (Carta4 == 50 || Carta4 == 51)
		{
			Setor3 = 1;
		}
		
		else if (Carta4 == 52 || Carta4 == 53)
		{
			Setor3 = 2;
		}
		
		else if (Carta4 == 54 || Carta4 == 55)
		{
			Setor3 = 3;
		}
		
	}
	
	public static void contas()
	{
		matriz();
		Conta1 = Mathf.Max(-4, matrizTridimensionalcartas [Setor0,0,Carta1] + valorbotao1);
		GD.Print("Conta1:"+Conta1+" Valor Carta:"+matrizTridimensionalcartas [Setor0,0,Carta1]+" Valor Botão:" + valorbotao1);
		Conta2 = Mathf.Max(-4, matrizTridimensionalcartas [Setor1,1,Carta2] + valorbotao2);
		GD.Print("Conta2:"+Conta2+" Valor Carta:"+matrizTridimensionalcartas [Setor1,1,Carta2]+" Valor Botão:" + valorbotao2);
		Conta3 = Mathf.Max(-4, matrizTridimensionalcartas [Setor2,2,Carta3] + valorbotao3);
		GD.Print("Conta3:"+Conta3+" Valor Carta:"+matrizTridimensionalcartas [Setor2,2,Carta3]+" Valor Botão:" + valorbotao3);
		Conta4 = Mathf.Max(-4, matrizTridimensionalcartas [Setor3,3,Carta4] + valorbotao4);
		GD.Print("Conta4:"+Conta4+" Valor Carta:"+matrizTridimensionalcartas [Setor3,3,Carta4]+" Valor Botão:" + valorbotao4);
	}
	
	private void _on_button_pressed()
	{
		contas();
		count++;
		
		preenchido1 = false;
		preenchido2 = false;
		preenchido3 = false;
		preenchido4 = false;
		usado1 = false;
		usado2 = false;
		usado3 = false;
		usado4 = false;
		
		Vector2[] posicoesiniciais = new Vector2[]
		{
			new Vector2(796,85),
			new Vector2(910,85),
			new Vector2(1027.87f,85),
			new Vector2(1147.5f,85),
		};
		
		Moeda1Sprite.Position = posicoesiniciais[0];
		Moeda2Sprite.Position = posicoesiniciais[1];
		Moeda3Sprite.Position = posicoesiniciais[2];
		Moeda4Sprite.Position = posicoesiniciais[3];

		listamoedas[0] = Moeda1; 
		listamoedas[1] = Moeda2;
		listamoedas[2] = Moeda3;
		listamoedas[3] = Moeda4;
			
		bool ord = true;
		while (ord)
		{
			ord = false;
			for (int i = 0; i < 3; i++)
			{
				if (listamoedas [i]<listamoedas[i+1])
				{
					int aux = listamoedas[i];
					listamoedas[i]=listamoedas[i+1];
					listamoedas[i+1]=aux;
					ord=true;
				}
			}
		}
			
		Moeda1Sprite = GetNode<Sprite2D>("Moeda1");
		Moeda1Sprite.Frame = listamoedas [0];
		
		Moeda2Sprite = GetNode<Sprite2D>("Moeda2");
		Moeda2Sprite.Frame = listamoedas [1];
					
		Moeda3Sprite = GetNode<Sprite2D>("Moeda3");
		Moeda3Sprite.Frame = listamoedas [2];
					
		Moeda4Sprite = GetNode<Sprite2D>("Moeda4");
		Moeda4Sprite.Frame = listamoedas [3];
					
		Carta1Sprite = GetNode<Sprite2D>("Flip1/Carta1");
		Carta1Sprite.Frame = Carta1;
		GD.Print("Carta 1: " +Carta1);
					
		Carta2Sprite = GetNode<Sprite2D>("Flip2/Carta2");
		Carta2Sprite.Frame = Carta2;
		GD.Print("Carta 2: "+Carta2);
					
		Carta3Sprite = GetNode<Sprite2D>("Flip3/Carta3");
		Carta3Sprite.Frame = Carta3;
		GD.Print("Carta 3: "+Carta3);
					
		Carta4Sprite = GetNode<Sprite2D>("Flip4/Carta4");
		Carta4Sprite.Frame = Carta4;
		GD.Print("Carta 4: "+Carta4);
		
		Flip1.Play("Flip1");
		Flip2.Play("Flip2");
		Flip3.Play("Flip3");
		Flip4.Play("Flip4");
		
		// Conta1
		switch (Setor0)
		{
			case 0:

			ProgressBar BarraAmbiente = GetNode <ProgressBar> ("Control/BarraAmbiente");
			Ambientecurrent_health = (Conta1 + Ambientecurrent_health);
			set_healthAmbiente(GetNode<ProgressBar>("Control/BarraAmbiente"), Ambientemax_health, Ambientecurrent_health);
			
			break;
			
			case 1:
				
			ProgressBar BarraSeguranca = GetNode <ProgressBar> ("Control/BarraSeguranca");
			Segurancacurrent_health = (Conta1 + Segurancacurrent_health);
			set_healthSeguranca(GetNode<ProgressBar>("Control/BarraSeguranca"), Segurancamax_health, Segurancacurrent_health);
			
			break;
			
			case 2:
			
			ProgressBar BarraEnsino = GetNode <ProgressBar> ("Control/BarraEnsino");
			Ensinocurrent_health = (Conta1 + Ensinocurrent_health);
			set_healthEnsino(GetNode<ProgressBar>("Control/BarraEnsino"), Ensinomax_health, Ensinocurrent_health);
			
			break;
			
			case 3: 

			ProgressBar BarraSaude = GetNode <ProgressBar> ("Control/BarraSaude");
			Saudecurrent_health = (Conta1 + Saudecurrent_health);
			set_healthSaude(GetNode<ProgressBar>("Control/BarraSaude"), Saudemax_health, Saudecurrent_health);
			
			break;
		}
		
		switch (Setor1)
		{
			case 0:

			ProgressBar BarraAmbiente = GetNode <ProgressBar> ("Control/BarraAmbiente");
			Ambientecurrent_health = (Conta2 + Ambientecurrent_health);
			set_healthAmbiente(GetNode<ProgressBar>("Control/BarraAmbiente"), Ambientemax_health, Ambientecurrent_health);
			
			break;
			
			case 1:
				
			ProgressBar BarraSeguranca = GetNode <ProgressBar> ("Control/BarraSeguranca");
			Segurancacurrent_health = (Conta2 + Segurancacurrent_health);
			set_healthSeguranca(GetNode<ProgressBar>("Control/BarraSeguranca"), Segurancamax_health, Segurancacurrent_health);
			
			break;
			
			case 2:
			
			ProgressBar BarraEnsino = GetNode <ProgressBar> ("Control/BarraEnsino");
			Ensinocurrent_health = (Conta2 + Ensinocurrent_health);
			set_healthEnsino(GetNode<ProgressBar>("Control/BarraEnsino"), Ensinomax_health, Ensinocurrent_health);
			
			break;
			
			case 3: 

			ProgressBar BarraSaude = GetNode <ProgressBar> ("Control/BarraSaude");
			Saudecurrent_health = (Conta2 + Saudecurrent_health);
			set_healthSaude(GetNode<ProgressBar>("Control/BarraSaude"), Saudemax_health, Saudecurrent_health);
			
			break;
		}
		
		switch (Setor2)
		{
			case 0:

			ProgressBar BarraAmbiente = GetNode <ProgressBar> ("Control/BarraAmbiente");
			Ambientecurrent_health = (Conta3 + Ambientecurrent_health);
			set_healthAmbiente(GetNode<ProgressBar>("Control/BarraAmbiente"), Ambientemax_health, Ambientecurrent_health);
			
			break;
			
			case 1:
				
			ProgressBar BarraSeguranca = GetNode <ProgressBar> ("Control/BarraSeguranca");
			Segurancacurrent_health = (Conta3 + Segurancacurrent_health);
			set_healthSeguranca(GetNode<ProgressBar>("Control/BarraSeguranca"), Segurancamax_health, Segurancacurrent_health);
			
			break;
			
			case 2:
			
			ProgressBar BarraEnsino = GetNode <ProgressBar> ("Control/BarraEnsino");
			Ensinocurrent_health = (Conta3 + Ensinocurrent_health);
			set_healthEnsino(GetNode<ProgressBar>("Control/BarraEnsino"), Ensinomax_health, Ensinocurrent_health);
			
			break;
			
			case 3: 

			ProgressBar BarraSaude = GetNode <ProgressBar> ("Control/BarraSaude");
			Saudecurrent_health = (Conta3 + Saudecurrent_health);
			set_healthSaude(GetNode<ProgressBar>("Control/BarraSaude"), Saudemax_health, Saudecurrent_health);
			
			break;
		}
		
		switch (Setor3)
		{
			case 0:

			ProgressBar BarraAmbiente = GetNode <ProgressBar> ("Control/BarraAmbiente");
			Ambientecurrent_health = (Conta4 + Ambientecurrent_health);
			set_healthAmbiente(GetNode<ProgressBar>("Control/BarraAmbiente"), Ambientemax_health, Ambientecurrent_health);
			
			break;
			
			case 1:
				
			ProgressBar BarraSeguranca = GetNode <ProgressBar> ("Control/BarraSeguranca");
			Segurancacurrent_health = (Conta4 + Segurancacurrent_health);
			set_healthSeguranca(GetNode<ProgressBar>("Control/BarraSeguranca"), Segurancamax_health, Segurancacurrent_health);
			
			break;
			
			case 2:
			
			ProgressBar BarraEnsino = GetNode <ProgressBar> ("Control/BarraEnsino");
			Ensinocurrent_health = (Conta4 + Ensinocurrent_health);
			set_healthEnsino(GetNode<ProgressBar>("Control/BarraEnsino"), Ensinomax_health, Ensinocurrent_health);
			
			break;
			
			case 3: 

			ProgressBar BarraSaude = GetNode <ProgressBar> ("Control/BarraSaude");
			Saudecurrent_health = (Conta4 + Saudecurrent_health);
			set_healthSaude(GetNode<ProgressBar>("Control/BarraSaude"), Saudemax_health, Saudecurrent_health);
			
			break;
		}
	
		Sprite2D [] cliques = {Moeda1Sprite, Moeda2Sprite, Moeda3Sprite, Moeda4Sprite};
		
		Vector2[] posicoes = new Vector2[]
		{
			new Vector2(228,572),
			new Vector2(515,572),
			new Vector2(802,572),
			new Vector2(1089,572),
		};
		
		if (Moeda1Sprite.Position == posicoes [0] || Moeda1Sprite.Position == posicoes [1] || Moeda1Sprite.Position == posicoes [2] || Moeda1Sprite.Position == posicoes [3])
		{
			usado1 = true;
		}
		
		if (Moeda2Sprite.Position == posicoes [0] || Moeda2Sprite.Position == posicoes [1] || Moeda2Sprite.Position == posicoes [2] || Moeda2Sprite.Position == posicoes [3])
		{
			usado2 = true;
		}
		
		if (Moeda3Sprite.Position == posicoes [0] || Moeda3Sprite.Position == posicoes [1] || Moeda3Sprite.Position == posicoes [2] || Moeda3Sprite.Position == posicoes [3])
		{
			usado3 = true;
		}
		
		if (Moeda4Sprite.Position == posicoes [0] || Moeda4Sprite.Position == posicoes [1] || Moeda4Sprite.Position == posicoes [2] || Moeda4Sprite.Position == posicoes [3])
		{
			usado4 = true;
		}
		
		valorbotao1 = 0;
		valorbotao2 = 0;
		valorbotao3 = 0;
		valorbotao4 = 0;
		
		if (Saudecurrent_health == 0 || Segurancacurrent_health == 0 || Ensinocurrent_health == 0 || Ambientecurrent_health == 0)
		{
			GetTree().ChangeSceneToFile("res://GameOver.tscn");
		}
	}
	
	private void _on_slot_moeda_1_pressed()
	{
		if (preenchido1 == false)
		{
			if (usado1 == false)
			{
				Moeda1Sprite = GetNode<Sprite2D>("Moeda1");
				//GD.Print(posicao1);
				Moeda1Sprite.Position = posicao1;
				valorbotao1 = listamoedas[0];
				//GD.Print("Valor botão 1:"+valorbotao1);
				preenchido1 = true;
				usado1 = true;
				moeda1 = 1;
				//GD.Print(valorbotao1);
			}
			else if (usado2 == false)
			{
				Moeda2Sprite = GetNode<Sprite2D>("Moeda2");
				Moeda2Sprite.Position = posicao1;
				valorbotao1 = listamoedas[1];
				//GD.Print("Valor botão 1:"+valorbotao1);
				preenchido1 = true;
				usado2 = true;
				moeda2 = 1;
				//GD.Print(valorbotao1);
			}
			else if (usado3 == false)
			{
				Moeda3Sprite = GetNode<Sprite2D>("Moeda3");
				Moeda3Sprite.Position = posicao1;
				preenchido1 = true;
				usado3 = true;
				valorbotao1 = listamoedas[2];
				//GD.Print("Valor botão 1:"+valorbotao1);
				moeda3 = 1;
				//GD.Print(valorbotao1);
			}
			else
			{
				Moeda4Sprite = GetNode<Sprite2D>("Moeda4");
				Moeda4Sprite.Position = posicao1;
				preenchido1 = true;
				usado4 = true;
				valorbotao1 = listamoedas[3];
				//GD.Print("Valor botão 1:"+valorbotao1);
				moeda4 = 1;
				//GD.Print(valorbotao1);
			}
		}
		else 
		{
			if (moeda1 == 1)
			{
				Moeda1Sprite = GetNode<Sprite2D>("Moeda1");
				Moeda1Sprite.Position = new Vector2(796,85);
				valorbotao1 = 0;
				//GD.Print("Valor botão 1:"+valorbotao1);
				preenchido1 = false;
				usado1 = false;
				moeda1 = 0;
			}
			else if (moeda2 == 1)
			{
				Moeda2Sprite = GetNode<Sprite2D>("Moeda2");
				Moeda2Sprite.Position = new Vector2(910,85);
				valorbotao1 = 0;
				//GD.Print("Valor botão 1:"+valorbotao1);
				preenchido1 = false;
				usado2 = false;
				moeda2 = 0;
			}
			else if (moeda3 == 1)
			{
				Moeda3Sprite = GetNode<Sprite2D>("Moeda3");
				Moeda3Sprite.Position = new Vector2(1027.87f,85);
				preenchido1 = false;
				usado3 = false;
				valorbotao1 = 0;
				//GD.Print("Valor botão 1:"+valorbotao1);
				moeda3 = 0;
			}
			else if (moeda4 == 1)
			{
				Moeda4Sprite = GetNode<Sprite2D>("Moeda4");
				Moeda4Sprite.Position = new Vector2(1147.5f,85);
				preenchido1 = false;
				usado4 = false;
				valorbotao1 = 0;
				//GD.Print("Valor botão 1:"+valorbotao1);
				moeda4 = 0;
			}
	}
}
	
	
	private void _on_slot_moeda_2_pressed()
	{
			if (preenchido2 == false)
		{
			if (usado1 == false)
				{
					Moeda1Sprite = GetNode<Sprite2D>("Moeda1");
					Moeda1Sprite.Position = posicao2;
					preenchido2 = true;
					usado1 = true;
					valorbotao2 = listamoedas[0];
					//GD.Print("Valor botão 2:"+valorbotao2);
					moeda1 = 2;
				}
				else if (usado2 == false)
				{
					Moeda2Sprite = GetNode<Sprite2D>("Moeda2");
					Moeda2Sprite.Position = posicao2;
					preenchido2 = true;
					usado2 = true;
					valorbotao2 = listamoedas[1];
					//GD.Print("Valor botão 2:"+valorbotao2);
					moeda2 = 2;
				}
				else if (usado3 == false)
				{
					Moeda3Sprite = GetNode<Sprite2D>("Moeda3");
					Moeda3Sprite.Position = posicao2;
					preenchido2 = true;
					usado3 = true;
					valorbotao2 = listamoedas[2];
					//GD.Print("Valor botão 2:"+valorbotao2);
					moeda3 = 2;
				}
				else
				{
					Moeda4Sprite = GetNode<Sprite2D>("Moeda4");
					Moeda4Sprite.Position = posicao2;
					preenchido2 = true;
					usado4 = true;
					valorbotao2 = listamoedas[3];
					//GD.Print("Valor botão 2:"+valorbotao2);
					moeda4 = 2;
			}
		}
		else 
		{
			if (moeda1 == 2)
			{
				Moeda1Sprite = GetNode<Sprite2D>("Moeda1");
				Moeda1Sprite.Position = new Vector2(796,85);
				valorbotao2 = 0;
				//GD.Print("Valor botão 2:"+valorbotao2);
				preenchido2 = false;
				usado1 = false;
				moeda1 = 0;
			}
			else if (moeda2 == 2)
			{
				Moeda2Sprite = GetNode<Sprite2D>("Moeda2");
				Moeda2Sprite.Position = new Vector2(910,85);
				valorbotao2 = 0;
				//GD.Print("Valor botão 2:"+valorbotao2);
				preenchido2 = false;
				usado2 = false;
				moeda2 = 0;
			}
			else if (moeda3 == 2)
			{
				Moeda3Sprite = GetNode<Sprite2D>("Moeda3");
				Moeda3Sprite.Position = new Vector2(1027.87f,85);
				preenchido2 = false;
				usado3 = false;
				valorbotao2 = 0;
				//GD.Print("Valor botão 2:"+valorbotao2);
				moeda3 = 0;
			}
			else if (moeda4 == 2)
			{
				Moeda4Sprite = GetNode<Sprite2D>("Moeda4");
				Moeda4Sprite.Position = new Vector2(1147.5f,85);
				preenchido2 = false;
				usado4 = false;
				valorbotao2 = 0;
				//GD.Print("Valor botão 2:"+valorbotao2);
				moeda4 = 0;
			}
		}
	}
	
	void _on_slot_moeda_3_pressed()
	{
		if (preenchido3 == false)
		{
		if (usado1 == false)
			{
				Moeda1Sprite = GetNode<Sprite2D>("Moeda1");
				Moeda1Sprite.Position = posicao3;
				preenchido3 = true;
				usado1 = true;
				valorbotao3 = listamoedas[0];
				//GD.Print("Valor botão 3:"+valorbotao3);
				moeda1 = 3;
			}
			else if (usado2 == false)
			{
				Moeda2Sprite = GetNode<Sprite2D>("Moeda2");
				Moeda2Sprite.Position = posicao3;
				preenchido3 = true;
				usado2 = true;
				valorbotao3 = listamoedas[1];
				//GD.Print("Valor botão 3:"+valorbotao3);
				moeda2 = 3;
			}
			else if (usado3 == false)
			{
				Moeda3Sprite = GetNode<Sprite2D>("Moeda3");
				Moeda3Sprite.Position = posicao3;
				preenchido3 = true;
				usado3 = true;
				valorbotao3 = listamoedas[2];
				//GD.Print("Valor botão 3:"+valorbotao3);
				moeda3 = 3;
			}
			else
			{
				Moeda4Sprite = GetNode<Sprite2D>("Moeda4");
				Moeda4Sprite.Position = posicao3;
				preenchido3 = true;
				usado4 = true;
				valorbotao3 = listamoedas[3];
				//GD.Print("Valor botão 3:"+valorbotao3);
				moeda4 = 3;
			}
		}
		
		else 
		{
			if (moeda1 == 3)
			{
				Moeda1Sprite = GetNode<Sprite2D>("Moeda1");
				Moeda1Sprite.Position = new Vector2(796,85);
				valorbotao3 = 0;
				//GD.Print("Valor botão 3:"+valorbotao3);
				preenchido3 = false;
				usado1 = false;
				moeda1 = 0;
			}
			else if (moeda2 == 3)
			{
				Moeda2Sprite = GetNode<Sprite2D>("Moeda2");
				Moeda2Sprite.Position = new Vector2(910,85);
				valorbotao3 = 0;
				//GD.Print("Valor botão 3:"+valorbotao3);
				preenchido3 = false;
				usado2 = false;
				moeda2 = 0;
			}
			else if (moeda3 == 3)
			{
				Moeda3Sprite = GetNode<Sprite2D>("Moeda3");
				Moeda3Sprite.Position = new Vector2(1027.87f,85);
				preenchido3 = false;
				usado3 = false;
				valorbotao3 = 0;
				//GD.Print("Valor botão 3:"+valorbotao3);
				moeda3 = 0;
			}
			else if (moeda4 == 3)
			{
				Moeda4Sprite = GetNode<Sprite2D>("Moeda4");
				Moeda4Sprite.Position = new Vector2(1147.5f,85);
				preenchido3 = false;
				usado4 = false;
				valorbotao3 = 0;
				//GD.Print("Valor botão 3:"+valorbotao3);
				moeda4 = 0;
			}
		}
	}
	
	void _on_slot_moeda_4_pressed()
	{
		if (preenchido4 == false)
		{
		if (usado1 == false)
			{
				Moeda1Sprite = GetNode<Sprite2D>("Moeda1");
				Moeda1Sprite.Position = posicao4;
				preenchido4 = true;
				usado1 = true;
				valorbotao4 = listamoedas[0];
				//GD.Print("Valor botão 4:"+valorbotao4);
				moeda1 = 4;
			}
			else if (usado2 == false)
			{
				Moeda2Sprite = GetNode<Sprite2D>("Moeda2");
				Moeda2Sprite.Position = posicao4;
				preenchido4 = true;
				usado2 = true;
				valorbotao4 = listamoedas[1];
				//GD.Print("Valor botão 4:"+valorbotao4);
				moeda2 = 4;
			}
			else if (usado3 == false)
			{
				Moeda3Sprite = GetNode<Sprite2D>("Moeda3");
				Moeda3Sprite.Position = posicao4;
				preenchido4 = true;
				usado3 = true;
				valorbotao4 = listamoedas[2];
				//GD.Print("Valor botão 4:"+valorbotao4);
				moeda3 = 4;
			}
			else
			{
				Moeda4Sprite = GetNode<Sprite2D>("Moeda4");
				Moeda4Sprite.Position = posicao4;
				preenchido4 = true;
				usado4 = true;
				valorbotao4 = listamoedas[3];
				//GD.Print("Valor botão 4:"+valorbotao4);
				moeda4 = 4;
			}
		}
		else 
		{
			if (moeda1 == 4)
			{
				Moeda1Sprite = GetNode<Sprite2D>("Moeda1");
				Moeda1Sprite.Position = new Vector2(796,85);
				preenchido4 = false;
				usado1 = false;
				valorbotao4 = 0;
				//GD.Print("Valor botão 4:"+valorbotao4);
				moeda1 = 0;
			}
			else if (moeda2 == 4)
			{
				Moeda2Sprite = GetNode<Sprite2D>("Moeda2");
				Moeda2Sprite.Position = new Vector2(910,85);
				preenchido4 = false;
				usado2 = false;
				valorbotao4 = 0;
				//GD.Print("Valor botão 4:"+valorbotao4);
				moeda2 = 0;
			}
			else if (moeda3 == 4)
			{
				Moeda3Sprite = GetNode<Sprite2D>("Moeda3");
				Moeda3Sprite.Position = new Vector2(1027.87f,85);
				preenchido4 = false;
				usado3 = false;
				valorbotao4 = 0;
				//GD.Print("Valor botão 4:"+valorbotao4);
				moeda3 = 0;
			}
			else if (moeda4 == 4)
			{
				Moeda4Sprite = GetNode<Sprite2D>("Moeda4");
				Moeda4Sprite.Position = new Vector2(1147.5f,85);
				preenchido4 = false;
				usado4 = false;
				valorbotao4 = 0;
				//GD.Print("Valor botão 4:"+valorbotao4);
				moeda4 = 0;
			}
		}
	}
	
	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (count <= 11)
		{
			//GD.Print ("Entrei");
			sorteios();
			matriz();
			
			listamoedas[0] = Moeda1; 
			listamoedas[1] = Moeda2;
			listamoedas[2] = Moeda3;
			listamoedas[3] = Moeda4;
			
			bool ord = true;
			while (ord)
			{
				ord = false;
				for (int i = 0; i < 3; i++)
				{
					if (listamoedas [i]<listamoedas[i+1])
					{
						int aux = listamoedas[i];
						listamoedas[i]=listamoedas[i+1];
						listamoedas[i+1]=aux;
						ord=true;
					}
				}
			}
		}
		
	if (preenchido1 == false || preenchido2 == false || preenchido3 == false || preenchido4 == false)
	{
		avancar.Visible = false;
	}
	else 
	{
		avancar.Visible = true;
	}
	
	if (count == 12)
	{
		GetTree().ChangeSceneToFile("res://Vitoria.tscn");
	}
	}
}


