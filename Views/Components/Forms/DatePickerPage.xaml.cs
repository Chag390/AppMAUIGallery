namespace AppMAUIGallery.Views.Components.Forms;

public partial class DatePickerPage : ContentPage
{
	public DatePickerPage()
	{
		InitializeComponent();
	}

    private void DatePicker_DateSelected(System.Object sender, Microsoft.Maui.Controls.DateChangedEventArgs e)
    {
		LblValue.Text = $"Data Antiga: {e.OldDate.ToString()} Nova data: { e.NewDate.ToString()}" ;


    }
}