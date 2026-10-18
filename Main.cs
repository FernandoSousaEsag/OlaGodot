using Godot;
using System;

public partial class Main : Node2D
{
	private Label pontosLabel;
	private PackedScene moedaScene;

	private Timer spawnTimer;

	private int numeroMoedas = 1;
	public int Pontos = 0;






	public override void _Ready()
	{
		pontosLabel = GetNode<Label>("PontosLabel");

		moedaScene = GD.Load<PackedScene>("res://Moeda.tscn"); // Carrega a cena moeda

		spawnTimer = GetNode<Timer>("SpawnTimer");
		spawnTimer.Timeout += CriarMoeda; // liga o sinal de timeout do timer ao método CriarMoeda
		
		CriarMoeda(); // Cria a primeira moeda


	
	}
	
	public void AdicionarPontos(int pontos)
		{
			Pontos += pontos;
			GD.Print("Pontos: " + Pontos);
			AtualizarPontuacao();
		}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

	}

	private void AtualizarPontuacao()
	{
		pontosLabel.Text = "Pontos: " + Pontos.ToString();
	}


	private void CriarMoeda()
	{
		if (numeroMoedas >= 6) // Limite de moedas no ecrã a 6
		{
			
			return;
		}
		
		// Cria uma instância da moeda a partir da cena carregada
		Moeda novaMoeda = moedaScene.Instantiate<Moeda>();
		novaMoeda.Position = new Vector2(
    (float)GD.RandRange(100, 1000),
    (float)GD.RandRange(100, 550)
);  // Define uma posição aleatória para a moeda

		AddChild(novaMoeda); // Adiciona a moeda como filho do nó principal
		numeroMoedas++; // Incrementa o contador de moedas
	}


}
