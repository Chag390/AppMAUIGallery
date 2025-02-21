using AppMAUIGallery.Views.Lists.Model;

namespace AppMAUIGallery.Views.Lists;

public partial class DataTemplateSelectorPage : ContentPage
{
	public DataTemplateSelectorPage()
	{
		InitializeComponent();

		CollectionViewControl.ItemsSource = MovieList.GetList();
       

    }
}