using Microsoft.Maui.Controls;

namespace MaryaMartins;

public partial class MainPage : ContentPage
{
	Personagens atual;
	Panda pandinha;
	Coala coalinha;
	Girafa girafinha;
	IDispatcherTimer timer;
	public MainPage()
	{
		InitializeComponent();

		pandinha = new Panda();
		coalinha = new Coala();
		girafinha = new Girafa();

		timer = Application.Current.Dispatcher.CreateTimer();
		timer.Interval = TimeSpan.FromSeconds(2);
		timer.Tick += (s, e) => PassouTempo();
		timer.Start();

		atual = pandinha;

		progressofome.Progress = atual.GetFome();
		progressosede.Progress = atual.GetSede();
		progressobrincadeira.Progress = atual.GetBrincadeira();

		Jogo.Source = atual.GetNomeDaFoto();
	}
	void Proximo(object sender, EventArgs args)
	{
		if (atual == pandinha)
			atual = coalinha;
		else if (atual == coalinha)
			atual = girafinha;
		else if (atual == girafinha)
			atual = pandinha;
		Jogo.Source = atual.GetNomeDaFoto();
		progressofome.Progress = atual.GetFome();
	}
	void AtualizaPersonagem()
	{
		progressofome.Progress = atual.GetFome();
		progressosede.Progress = atual.GetSede();
		progressobrincadeira.Progress = atual.GetBrincadeira();
	}
	void Comer(object sender, EventArgs args)
	{
		atual.SetFome(atual.GetFome() + 0.1);
		AtualizaPersonagem();
	}
	void Beber(object sender, EventArgs args)
	{
		atual.SetSede(atual.GetSede() + 0.1);
		AtualizaPersonagem();
	}
	void Brincar(object sender, EventArgs args)
	{
		atual.SetBrincadeira(atual.GetBrincadeira() + 0.1);
		AtualizaPersonagem();
	}
	void PassouTempo()
	{
		var estavamorto = atual.GetMorto();
		pandinha.SetFome(pandinha.GetFome() - 0.1);
		girafinha.SetFome(girafinha.GetFome() - 0.1);
		coalinha.SetFome(coalinha.GetFome() - 0.1);

		pandinha.SetSede(pandinha.GetSede() - 0.1);
		girafinha.SetSede(girafinha.GetSede() - 0.1);
		coalinha.SetSede(coalinha.GetSede() - 0.1);

		pandinha.SetBrincadeira(pandinha.GetBrincadeira() - 0.1);
		girafinha.SetBrincadeira(girafinha.GetBrincadeira() - 0.1);
		coalinha.SetBrincadeira(coalinha.GetBrincadeira() - 0.1);

		if (estavamorto != atual.GetMorto())
			Jogo.Source = atual.GetNomeDaFoto();

		AtualizaPersonagem();

		if (pandinha.GetMorto() &&
			coalinha.GetMorto() &&
			girafinha.GetMorto())
		{
			timer.Stop();
			Application.Current.MainPage = new GameOverPage();
		}
	}

}

