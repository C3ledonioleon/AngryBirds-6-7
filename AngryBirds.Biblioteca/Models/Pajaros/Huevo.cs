namespace AngryBirds.Biblioteca.Models;

public class Huevo
{
    public int Peso { get; }

  
     public Huevo(int peso)
    {
        if (peso <= 0)
            throw new ArgumentException("El peso debe ser mayor a 0");

        Peso = peso;
    }

      public int ObtenerFuerza() => Peso;

}