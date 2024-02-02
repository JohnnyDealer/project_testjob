namespace FiguresUI.Domain;

public sealed class Ellipse : AbstractFigure<Ellipse>
{
	public Ellipse()
	{
		Color = Colors.DeepPink;
		TextColor = Colors.DarkViolet;
		Text = "Some text";
		TextPosition = (100, 100, 100, 100);
	}

	public override void SetProperties(Ellipse other)
	{
		Color = other.Color;
		TextColor = other.TextColor;
		Text = other.Text;
		TextPosition = other.TextPosition;
		Height = other.Height;
		Width = other.Width;		
	}
}
