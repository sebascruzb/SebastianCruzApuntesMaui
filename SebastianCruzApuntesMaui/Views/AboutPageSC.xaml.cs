namespace SebastianCruzApuntesMaui.Views;

public partial class AboutPageSC : ContentPage
{
	public AboutPageSC()
	{
		InitializeComponent();
	}

    private async void LearnMore_Clicked(object sender, EventArgs e)
    {
        await Launcher.Default.OpenAsync("https://aka.ms/maui");
    }
}