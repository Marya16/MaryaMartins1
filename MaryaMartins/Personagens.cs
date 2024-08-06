namespace MaryaMartins;

public class Personagens() 
{
  protected string NomedafotoMorto;
  protected bool Morto = false;
  protected double Fome;
  protected double Sede;
  protected double Brincadeira;

  protected string Nomedafoto;

  public string GetNomeDaFoto()
  {
    if (Morto)
      return NomedafotoMorto;
    else
      return Nomedafoto;
  }

  public double GetFome()
  {
    return Fome;
  }
  public void SetFome(double F)
  {
    if (F > 1)
     Fome = 1;
    else if (F <= 0) 
      Fome = 0;
    else
     Fome = F;

    if(Fome <= 0.01)
      Morto = true;
  }
  public double GetSede()
  {
    return Sede;
  }
  public void SetSede(double S)
  {
    if (S > 1)
     Sede = 1;
    else if (S <= 0) 
      Sede = 0;
    else
     Sede = S;

    if(Sede <= 0.01)
      Morto = true;
  }
  public double GetBrincadeira()
  {
    return Brincadeira;
  }
  public void SetBrincadeira(double B)
  {
    if (B > 1)
     Brincadeira = 1;
    else if (B <= 0) 
      Brincadeira = 0;
    else
     Brincadeira = B;

    if(Brincadeira <= 0.01)
      Morto = true;
  }
  public bool GetMorto()
   {
    return Morto;
   }
}