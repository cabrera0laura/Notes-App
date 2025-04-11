using Microsoft.Maui.ApplicationModel;

namespace NotesApp;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}

    private void PerfilButao_Clicked(object sender, EventArgs e)
    {
        Uri link = new Uri("https://github.com/cabrera0laura");

        Launcher.OpenAsync(link);
    }
}