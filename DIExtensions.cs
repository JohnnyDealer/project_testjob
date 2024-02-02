using FiguresUI.Repository;
using FiguresUI.Repository.Abstract;
using FiguresUI.Services;

namespace FiguresUI;

public static class DIExtensions
{
	public static MauiAppBuilder RegisterServices(this MauiAppBuilder mauiAppBuilder)
	{
		mauiAppBuilder.Services.AddSingleton<MainPage>();
		mauiAppBuilder.Services.AddSingleton<IFigureService, FigureService>();

		mauiAppBuilder.Services.AddSingleton<IEllipseInMemoryRepository, EllipseInMemoryRepository>();
		mauiAppBuilder.Services.AddSingleton<IRectangleInMemoryRepository, RectangleInMemoryRepository>();

		return mauiAppBuilder;
	}
}
