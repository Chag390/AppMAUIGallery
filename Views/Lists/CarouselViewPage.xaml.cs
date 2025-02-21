using AppMAUIGallery.Views.Lists.Model;


namespace AppMAUIGallery.Views.Lists;

public partial class CarouselViewPage : ContentPage
{
	public CarouselViewPage()
	{
		InitializeComponent();
        CarouselViewControl.ItemsSource = MovieList.GetList();
    }
}