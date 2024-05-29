using Godot;
using System;

[GlobalClass]
public partial class ToolBase : Button
{
	protected Texture2D ToolIcon { set; get; } = GD.Load<Texture2D>("res://Assets/Textures/Tools/Missing.svg");

	ToolBase() 
	{
		Icon = ToolIcon;
		ToggleMode = true;
		AddThemeConstantOverride("icon_max_width", 32);
	}

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	protected void LeftMouseAction()
	{

	}

	protected void RightMouseAction()
	{

	}
}
