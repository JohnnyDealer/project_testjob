using FiguresUI.Domain;
using FiguresUI.Dto;
using FiguresUI.Services;

namespace FiguresUI
{
	public partial class MainPage : ContentPage
	{
		private readonly IFigureService _figureService;

		public MainPage(IFigureService figureService)
		{
			InitializeComponent();

			_figureService = figureService;

			_figureService.ChangeFigureParamsAsync(GetCurrentEllipse());
			_figureService.ChangeFigureParamsAsync(GetCurrentRectangle());
		}

		private EllipseDto GetCurrentEllipse()
			=> new()
			{
				Color = EllipseFigure.Fill,
				Text = EllipseText.Text,
				TextColor = EllipseText.TextColor,
				TextPosition = (EllipseText.Margin.Left, EllipseText.Margin.Top, EllipseText.Margin.Right, EllipseText.Margin.Bottom),
				Height = EllipseFigure.HeightRequest,
				Width = EllipseFigure.WidthRequest,
			};

		private RectangleDto GetCurrentRectangle()
			=> new()
			{
				Color = RectangleFigure.Fill,
				Text = RectangleText.Text,
				TextColor = RectangleText.TextColor,
				TextPosition = (RectangleText.Margin.Left, RectangleText.Margin.Top, RectangleText.Margin.Right, RectangleText.Margin.Bottom),
				Height = RectangleFigure.HeightRequest,
				Width = RectangleFigure.WidthRequest,
				Rotation = RectangleFigure.Rotation
			};

		private void SetCurrentEllipse(EllipseDto ellipseDto)
		{
			EllipseFigure.Fill = ellipseDto.Color;
			EllipseText.Text = ellipseDto.Text;
			EllipseText.TextColor = ellipseDto.TextColor;
			EllipseFigure.HeightRequest = ellipseDto.Height;
			EllipseFigure.WidthRequest = ellipseDto.Width;
			EllipseText.Margin = new Thickness(
				ellipseDto.TextPosition.Left,
				ellipseDto.TextPosition.Top,
				ellipseDto.TextPosition.Right,
				ellipseDto.TextPosition.Bottom
			);
		}

		private void SetCurrentRectangle(RectangleDto rectangleDto)
		{
			RectangleFigure.Fill = rectangleDto.Color;
			RectangleText.Text = rectangleDto.Text;
			RectangleText.TextColor = rectangleDto.TextColor;
			RectangleFigure.HeightRequest = rectangleDto.Height;
			RectangleFigure.WidthRequest = rectangleDto.Width;
			RectangleFigure.Rotation = rectangleDto.Rotation;
			RectangleText.Margin = new Thickness(
				rectangleDto.TextPosition.Left,
				rectangleDto.TextPosition.Top,
				rectangleDto.TextPosition.Right,
				rectangleDto.TextPosition.Bottom
			);
		}

		private void LayoutSwitch_Toggled(object sender, ToggledEventArgs e)
		{
			if (e.Value is true)
			{
				var rectangleDto = GetCurrentRectangle();

				_figureService.ChangeFigureParamsAsync(rectangleDto);

				var oldEllipseTask = _figureService.GetCurrentFigureAsync<Ellipse>();
				var oldEllipseDto = (EllipseDto)oldEllipseTask.Result;

				SetCurrentEllipse(oldEllipseDto);
			}
			else
			{
				var ellipseDto = GetCurrentEllipse();

				_figureService.ChangeFigureParamsAsync(ellipseDto);

				var oldRectangleTask = _figureService.GetCurrentFigureAsync<Rectangle>();
				var oldRectangleDto = (RectangleDto)oldRectangleTask.Result;

				SetCurrentRectangle(oldRectangleDto);
			}

			SwitchVisibility();
		}

		private void SwitcherRectangleColor_Toggled(object sender, ToggledEventArgs e)
			=> RectangleFigure.Fill = e.Value
					? Colors.ForestGreen
					: Colors.Red;

		private void SwitcherRectangleTextColor_Toggled(object sender, ToggledEventArgs e)
			=> RectangleText.TextColor = e.Value
					? Colors.Black
					: Colors.White;

		private void SwitcherEllipseColor_Toggled(object sender, ToggledEventArgs e)
			=> EllipseFigure.Fill = e.Value					
					? Colors.Purple
					: Colors.Orange;
		
		private void SwitcherEllipseTextColor_Toggled(object sender, ToggledEventArgs e)
			=> EllipseText.TextColor = e.Value
					? Colors.Black
					: Colors.Yellow;

		private void EllipseEntry_TextChanged(object sender, TextChangedEventArgs e)
			=> EllipseText.Text = e.NewTextValue;

		private void RectangleEntry_TextChanged(object sender, TextChangedEventArgs e)
			=> RectangleText.Text = e.NewTextValue;

		private void SwitchVisibility()
		{
			StackEllipse.IsVisible = !StackEllipse.IsVisible;
			StackRectangle.IsVisible = !StackRectangle.IsVisible;
		}

	}
}
