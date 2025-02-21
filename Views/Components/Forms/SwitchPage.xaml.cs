namespace AppMAUIGallery.Views.Components.Forms;

public partial class SwitchPage : ContentPage
{
	public SwitchPage()
	{
		InitializeComponent();
	}

    private void Switch_Toggled(System.Object sender, Microsoft.Maui.Controls.ToggledEventArgs e)
    {
		LblStatus.Text = $" Marcado: {e.Value}";
    }
}