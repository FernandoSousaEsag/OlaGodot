using Godot;


public partial class Moeda : Area2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		//Evento quando outra Area2D entra na área da moeda, o Godot chama o método AoEntrarArea
		AreaEntered += AoEntrarArea;
	}

	private void AoEntrarArea(Area2D area)
	{
		
		
		if (area.Name == "Player")
		{
			GD.Print("Moeda apanhada!");
			QueueFree();

			Main main = GetParent<Main>();
			if (main != null)  // Se a variável main realmente contém um objeto e não está vazia, então executa o código
			{
				main.AdicionarPontos(1);
			}

			
		}
	}
	


}
