namespace AppMAUIGallery.Views.Components.Forms;

public partial class RadioButtonPage : ContentPage
{
	public RadioButtonPage()
	{
		InitializeComponent();
	}

    private void RadioButton_CheckedChanged(System.Object sender, Microsoft.Maui.Controls.CheckedChangedEventArgs e)
    {
		if(e.Value == true)
		{
			var Value = ((RadioButton)sender).Content;
			LblResultAsk01.Text = $"Você escolheu: {Value} ";
		}
    }
}