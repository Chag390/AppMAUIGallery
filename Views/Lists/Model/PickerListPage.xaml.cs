namespace AppMAUIGallery.Views.Lists.Model;

public partial class PickerListPage : ContentPage
{
	public PickerListPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {

		PickerControl.ItemsSource = MovieList.GetList();

		PickerControl.SelectedIndex = 3;
		
    }



}