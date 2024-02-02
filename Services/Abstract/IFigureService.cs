using FiguresUI.Domain;
using FiguresUI.Dto.Abstract;

namespace FiguresUI.Services;

public interface IFigureService
{
	Task ChangeFigureParamsAsync<TFigure>(IFigureDto<TFigure> figureDto) where TFigure : AbstractFigure<TFigure>;

	Task<IFigureDto<TFigure>> GetCurrentFigureAsync<TFigure>() where TFigure : AbstractFigure<TFigure>;	
}
