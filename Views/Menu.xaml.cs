using AppMAUIGallery.Repositories;

namespace AppMAUIGallery.Views;

public partial class Menu : ContentPage
{
    private IGroupComponentRepository1 _repository;
	public Menu()
	{
		InitializeComponent();

        // TO DO - DI Dependency Injection

        _repository = new GroupComponentRepository();

        MenuCollection.ItemsSource = _repository.GetGroupsComponents();

    }

    private void OnTapComponent ( object sender, EventArgs e )
	{
		var label = (Label) sender;
		var tap = (TapGestureRecognizer)label.GestureRecognizers[0];
		var page = (Type)tap.CommandParameter;

        ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage((Page)Activator.CreateInstance(page));
        ((FlyoutPage)App.Current.MainPage).IsPresented = false;

    }

    private void OnTapInicio(object sender, TappedEventArgs e)
    {
        ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new AppMAUIGallery.Views.MainPage());
        ((FlyoutPage)App.Current.MainPage).IsPresented = false;
    }
}