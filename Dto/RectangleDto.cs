using FiguresUI.Domain;
using FiguresUI.Dto.Abstract;

namespace FiguresUI.Dto;

public record struct RectangleDto(
	Brush Color,
	string Text,
	Color TextColor,
	(double Left, double Top, double Right, double Bottom) TextPosition,
	double Height,
	double Width,
	double Rotation
) : IFigureDto<Rectangle>
{
	public readonly Rectangle ToDomain()
		=> new()
		{
			Color = Color,
			Text = Text,
			TextColor = TextColor,
			TextPosition = TextPosition,
			Height = Height,
			Width = Width,
			Rotation = Rotation
		};

	public readonly IFigureDto<Rectangle> FromDomain() => this;
}
