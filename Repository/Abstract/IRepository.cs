using FiguresUI.Domain;

namespace FiguresUI.Repository.Abstract;

public interface IRepository<TEntity> where TEntity : AbstractFigure<TEntity>, new()
{
	Task Update(TEntity item);
}
