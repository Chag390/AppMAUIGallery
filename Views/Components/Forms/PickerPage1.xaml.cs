using System.ComponentModel;

namespace AppMAUIGallery.Views.Components.Forms;

public partial class PickerPage1 : ContentPage
{
	public PickerPage1()
	{
		InitializeComponent();
	}

    private void Picker_SelectedIndexChanged(System.Object sender, System.EventArgs e)
    {
        var component = ((Picker)sender);
        string BrandName = (string)component.SelectedItem;

        /*component.SelectedIndex = 4;
        component.SelectedItem = component.ItemsSource[0];*/

        LblValue.Text = BrandName;
       
    }
}