using Godot;
using System;

public partial class world : Node2D
{
	private PackedScene _packedScene;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_packedScene = (PackedScene) GD.Load("res://random_sprite.tscn");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public override void _UnhandledInput(InputEvent @event)
	{
		if (@event is InputEventMouseButton mouseEvent)
		{
			if (!mouseEvent.IsPressed())
			{
				return;
			}
			// create instance of new random sprite
			Sprite2D sprite2d = (Sprite2D) _packedScene.Instantiate();
			sprite2d.Position = mouseEvent.Position;
			this.AddChild(sprite2d);
		}
	}
}
