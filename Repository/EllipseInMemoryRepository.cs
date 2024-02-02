using FiguresUI.Domain;
using FiguresUI.Repository.Abstract;

namespace FiguresUI.Repository;

public sealed class EllipseInMemoryRepository : IEllipseInMemoryRepository
{
	public Ellipse InMemoryEllipse { get; set; }

	public EllipseInMemoryRepository()
	{
		InMemoryEllipse = new() {
			Color = Colors.Chocolate,
			Text = string.Empty,
			TextColor = Colors.Tomato
		};
	}

	public async Task UpdateAsync(Ellipse item)
	{
		InMemoryEllipse.SetProperties(item);

		await Task.CompletedTask;
	}

	public async Task<Ellipse> GetCurrentAsync() => await Task.FromResult(InMemoryEllipse);
}
