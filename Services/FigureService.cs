using FiguresUI.Domain;
using FiguresUI.Dto.Abstract;
using FiguresUI.Repository.Abstract;

namespace FiguresUI.Services;

public sealed class FigureService : IFigureService
{
	private readonly IEllipseInMemoryRepository _ellipseInMemoryRepository;
	private readonly IRectangleInMemoryRepository _rectangleInMemoryRepository;

	public FigureService(
		IEllipseInMemoryRepository ellipseInMemoryRepository,
		IRectangleInMemoryRepository rectangleInMemoryRepository
	)
	{
		_ellipseInMemoryRepository = ellipseInMemoryRepository;
		_rectangleInMemoryRepository = rectangleInMemoryRepository;
	}

	public async Task ChangeFigureParamsAsync<TFigure>(IFigureDto<TFigure> figureDto) where TFigure : AbstractFigure<TFigure>
	{
		var domainEntity = figureDto.ToDomain();

		if (typeof(TFigure) == typeof(Ellipse))
			await _ellipseInMemoryRepository.UpdateAsync((Ellipse)(object)domainEntity);
		else
			await _rectangleInMemoryRepository.UpdateAsync((Rectangle)(object)domainEntity);
	}

	public async Task<IFigureDto<TFigure>> GetCurrentFigureAsync<TFigure>() where TFigure : AbstractFigure<TFigure>
	{
		if (typeof(TFigure) == typeof(Ellipse))
			return (IFigureDto<TFigure>)(IFigureDto<Ellipse>)(await _ellipseInMemoryRepository.GetCurrentAsync()).ToDto();
		else
			return (IFigureDto<TFigure>)(IFigureDto<Rectangle>)(await _rectangleInMemoryRepository.GetCurrentAsync()).ToDto();
	}

}
