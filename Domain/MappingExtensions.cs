using FiguresUI.Dto;

namespace FiguresUI.Domain;

public static class MappingExtensions
{

	public static EllipseDto ToDto(this Ellipse ellipse)
		=> new(
			Color: ellipse.Color,
			Width: ellipse.Width,
			Height: ellipse.Height,
			Text: ellipse.Text,
			TextColor: ellipse.TextColor,
			TextPosition: ellipse.TextPosition
		);

	public static RectangleDto ToDto(this Rectangle rectangle)
		=> new(
			Color: rectangle.Color,
			Width: rectangle.Width,
			Height: rectangle.Height,
			Text: rectangle.Text,
			TextColor: rectangle.TextColor,
			TextPosition: rectangle.TextPosition,
			Rotation: rectangle.Rotation
		);

}
