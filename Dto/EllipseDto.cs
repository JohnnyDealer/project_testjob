using FiguresUI.Domain;
using FiguresUI.Dto.Abstract;

namespace FiguresUI.Dto;

public record struct EllipseDto(
	Brush Color,
	string Text,
	Color TextColor,
	(double Left, double Top, double Right, double Bottom) TextPosition,
	double Height,
	double Width
) : IFigureDto<Ellipse>
{
	public readonly Ellipse ToDomain()
		=> new()
		{
			Color = Color,
			Text = Text,
			TextColor = TextColor,
			TextPosition = TextPosition,
			Height = Height,
			Width = Width
		};

	public readonly IFigureDto<Ellipse> FromDomain() => this;
}
