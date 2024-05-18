using Godot;
using System;

public partial class SpriteRandom : MainMovement
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		uint movement = GD.Randi() % 4;
		const float AMOUNT = 5;
		
		if (movement == 0)
		{
			this.Position += new Vector2(0, -AMOUNT);
		}
		
		if (movement == 1)
		{
			this.Position += new Vector2(0, AMOUNT);
		}
		
		if (movement == 2)
		{
			this.Position += new Vector2(-AMOUNT, 0);
		}
		
		if (movement == 3)
		{
			this.Position += new Vector2(AMOUNT, 0);
		}
	}
}
