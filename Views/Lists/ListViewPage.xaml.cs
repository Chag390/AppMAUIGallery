using AppMAUIGallery.Views.Lists.Model;

namespace AppMAUIGallery.Views.Lists;

public partial class ListViewPage : ContentPage
{
	public ListViewPage()
	{
		InitializeComponent();

		
	}

    private void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        ListViewControl.ItemsSource = MovieList.GetGroupList().Take(3);
    }

    private void ListViewControl_ItemSelected(System.Object sender, Microsoft.Maui.Controls.SelectedItemChangedEventArgs e)
    {
        var movie = (Movie)e.SelectedItem;

        App.Current.MainPage.DisplayAlert("Filme selecionado!", $"O filme selecionado é: {movie.Name}", "OK");
    }

    private async void ListViewControl_Refreshing(System.Object sender, System.EventArgs e)

    {
        ListViewControl.IsRefreshing = true;
        await Task.Delay(3000);
        ListViewControl.ItemsSource = MovieList.GetGroupList();

        ListViewControl.IsRefreshing = false;
    }
}