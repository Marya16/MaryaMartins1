namespace MaryaMartins;

public class Personagens() 
{
  protected double Fome;
  protected double Sede;
  protected double Brincadeira;

  protected string Nomedafoto;

  public string GetNomeDaFoto()
  {
    return Nomedafoto;
  }

  public double GetFome()
  {
    return Fome;
  }
  public void SetFome(double F)
  {
    Fome=F;
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