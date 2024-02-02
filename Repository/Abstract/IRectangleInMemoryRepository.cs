using FiguresUI.Domain;

namespace FiguresUI.Repository.Abstract;

public interface IRectangleInMemoryRepository
{
	Task UpdateAsync(Rectangle item);

	Task<Rectangle> GetCurrentAsync();
}
