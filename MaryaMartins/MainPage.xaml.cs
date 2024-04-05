namespace MaryaMartins;

public partial class MainPage : ContentPage
{
	Personagens atual;
	Panda pandinha = new Panda();
    Coala coalinha = new Coala();
	Girafa girafinha = new Girafa();
	public MainPage()
	{
		InitializeComponent();
		 
		atual=pandinha;
	
		Jogo.Source =  atual.GetNomeDaFoto();
	}
	void Proximo (object sender, EventArgs args)
	{
		if(atual == pandinha)
			atual = coalinha;
		else if(atual == coalinha)
			atual = girafinha;
		else if(atual == girafinha)
			atual = pandinha;
		Jogo.Source =  atual.GetNomeDaFoto();
		progressBarFome.Progress = atual.GetFome();
	}

	void Comer (object sender, EventArgs args)		
	{
		 atual.SetFome(atual.GetFome()+ 0,1);
	}
	
}

