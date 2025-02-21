
using AppMAUIGallery.Views.Lists.Model;

namespace AppMAUIGallery.Views.Lists;

public partial class BindableLayoutPage : ContentPage
{
	public BindableLayoutPage()
	{
		InitializeComponent();

		var layout = VerticalStackLayoutControl;
		var list = MovieList.GetList();

		BindableLayout.SetItemsSource(layout, list);	

    }
}