using FiguresUI.Domain;
using FiguresUI.Repository.Abstract;

namespace FiguresUI.Repository;

public sealed class RectangleInMemoryRepository : IRectangleInMemoryRepository
{
	public required Rectangle InMemoryRectangle { get; set; }

	public RectangleInMemoryRepository()
	{
		InMemoryRectangle = new() { 
			Color = Colors.RoyalBlue,
			Text = string.Empty,
			TextColor = Colors.IndianRed,
		};
	}

	public async Task UpdateAsync(Rectangle item)
	{
		InMemoryRectangle.SetProperties(item);

		await Task.CompletedTask;
	}

	public async Task<Rectangle> GetCurrentAsync() => await Task.FromResult(InMemoryRectangle);
}
