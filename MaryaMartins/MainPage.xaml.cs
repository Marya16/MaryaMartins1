using Microsoft.Maui.Controls;

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
		  
		var timer = Application.Current.Dispatcher.CreateTimer();
		  timer.Interval = TimeSpan.FromSeconds(2);
		    timer.Tick += (s,e) =>
		  PassouTempo();
		  timer.Start();

		atual=pandinha; 

		progressofome.Progress=atual.GetFome();
		progressosede.Progress=atual.GetSede();
		progressobrincadeira.Progress=atual.GetBrincadeira();
	
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
		progressofome.Progress = atual.GetFome();
	}
  void AtualizaPersonagem()
  {
	    progressofome.Progress=atual.GetFome();
		progressosede.Progress=atual.GetSede();
		progressobrincadeira.Progress=atual.GetBrincadeira();
  }
	void Comer (object sender, EventArgs args)		
	{
		 atual.SetFome(atual.GetFome()+ 0.1);
		 AtualizaPersonagem();
	}
	void Beber (object sender, EventArgs args)		
	{
		 atual.SetSede(atual.GetSede()+ 0.1);
		 AtualizaPersonagem();
	}
	void Brincar (object sender, EventArgs args)		
	{
		 atual.SetBrincadeira(atual.GetBrincadeira()+ 0.1);
		 AtualizaPersonagem();
	}
	void PassouTempo()
	{
		var estavamorto = atual.GetMorto();
		atual.SetFome(atual.GetFome()- 0.1);
		atual.SetSede(atual.GetSede()- 0.1);
		atual.SetBrincadeira(atual.GetBrincadeira()- 0.1);
		if(estavamorto != atual.GetMorto())
			Jogo.Source =  atual.GetNomeDaFoto();

		AtualizaPersonagem();
	}

}

