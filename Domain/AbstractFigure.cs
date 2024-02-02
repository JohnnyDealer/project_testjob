namespace FiguresUI.Domain;

public abstract class AbstractFigure<T> where T : AbstractFigure<T>
{
	public required Brush Color { get; set; }

	public double Height { get; set; }

	public double Width { get; set; }

	public required string Text { get; set; }

	public required Color TextColor { get; set; }

	public (double Left, double Top, double Right, double Bottom) TextPosition { get; set; }

	public abstract void SetProperties(T other);
}
