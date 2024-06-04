using Godot;
using System;

public partial class AppRoot : Control{
	
	[ExportCategory("App Settings")]
	[Export]
	public float appScale 
	{ 
		set{

		}
		get{
			return appScale;
		}
	}

	public AppRoot(){
		appScale = 1.0f;
	}
}