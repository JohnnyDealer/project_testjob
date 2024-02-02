namespace FiguresUI.Domain;

public sealed class Rectangle : AbstractFigure<Rectangle>
{
	public Rectangle()
	{
		Color = Colors.OrangeRed;
		TextColor = Colors.Olive;
		Text = "Some text";
		TextPosition = (100, 100, 100, 100);
	}	

	public double Rotation { get; set; }

	public override void SetProperties(Rectangle other)
	{
		Color = other.Color;
		TextColor = other.TextColor;
		Text = other.Text;
		TextPosition = other.TextPosition;
		Height = other.Height;
		Width = other.Width;
		Rotation = other.Rotation;
	}
}
