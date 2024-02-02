using FiguresUI.Domain;

namespace FiguresUI.Repository.Abstract;

public interface IEllipseInMemoryRepository
{
	Task UpdateAsync(Ellipse item);

	Task<Ellipse> GetCurrentAsync();
}
