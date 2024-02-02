using FiguresUI.Domain;

namespace FiguresUI.Dto.Abstract;

public interface IFigureDto<TFigure> where TFigure : AbstractFigure<TFigure>
{
    TFigure ToDomain();

    IFigureDto<TFigure> FromDomain();
}
