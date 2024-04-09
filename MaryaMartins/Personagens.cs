namespace MaryaMartins;

public class Personagens() 
{
  protected string NomedafotoMorto;
  protected bool Morto;
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
    else if (F < 0) 
    { 
      Fome = 0;
      Morto = true;
    }
    else
     Fome = F;
  }
  public double GetSede()
  {
    return Sede;
  }
  public void SetSede(double S)
  {
   Sede=S;
  }
  public double GetBrincadeira()
  {
    return Brincadeira;
  }
  public void SetBrincadeira(double B)
  {
   Brincadeira=B;
  }
}