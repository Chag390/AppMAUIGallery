namespace AppMAUIGallery.Views.Components.Forms;

public partial class StepperPage : ContentPage
{
	public StepperPage()
	{
		InitializeComponent();
	}

    private void Stepper_ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
    {
		LblValue.Text = $"Antigo: {e.OldValue} Atual - Novo: {e.NewValue}";
    }
}