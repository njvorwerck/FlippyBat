using Godot;
using System;

public partial class Blah : Panel
{
	// Called when the node enters the scene tree for the first time.
	RichTextLabel label;
	Button button;
	public override void _Ready()
	{
		label = (RichTextLabel)GetNode("RichTextLabel");
		button = (Button)GetNode("Button");
		button.Pressed += onPress;
	}

	private void onPress() {
		label.Text = "Could this be the coolest game of our generation?";
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
