using System.ComponentModel.Design;

namespace AppMAUIGallery.Views.Components.Forms;

public partial class CheckBoxPage : ContentPage
{
	public CheckBoxPage()
	{
		InitializeComponent();
	}

    private void CheckBox_CheckedChanged(System.Object sender, Microsoft.Maui.Controls.CheckedChangedEventArgs e)
    {
		if (e.Value == true)
		{
			CheckBox checkbox = ((CheckBox)sender);
			HorizontalStackLayout stack = (HorizontalStackLayout)checkbox.Parent;
			Label label = (Label)stack.Children[1];
			LblStatus.Text = label.Text;
		}
		else
		{
			LblStatus.Text = String.Empty;
		}
	
    }
}