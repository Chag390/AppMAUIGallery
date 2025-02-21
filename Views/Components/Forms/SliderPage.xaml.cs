namespace AppMAUIGallery.Views.Components.Forms;

public partial class SliderPage : ContentPage
{
	public SliderPage()
	{
		InitializeComponent();
	}

    private void Slider_DragStarted(System.Object sender, System.EventArgs e)
    {
        LblStatus.Text = "Iniciou o arrasto!";
    }

    private void Slider_DragCompleted(System.Object sender, System.EventArgs e)
    {
        LblStatus.Text = "Completou o arrasto!";
    }

    private void Slider_ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
    {
        LblValue.Text = $"Valor: {+ ((int)e.NewValue)}%";
    }
}