namespace AngryBirds.Biblioteca;

public class Huevo
{
    public int Peso { get; }
    public int Fuerza => Peso;

    public Huevo(int peso)
    {
        if (peso <= 0)
            throw new ArgumentException("El peso debe ser mayor a 0");

        Peso = peso;
    }
}