namespace MaryaMartins;

public partial class GameOverPage : ContentPage
{
    public GameOverPage()
	{
		InitializeComponent();
    }
    void Button_Clicked(object sender,EventArgs args)
	{ 
      Application.Current.MainPage = new MainPage();
	}
}
