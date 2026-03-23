using AngryBirds.Biblioteca.Models.Abstract;

namespace AngryBirds.Biblioteca.Models;

public class ParedMadera : Obstaculo
{
    public int Ancho { get; set; }

    public ParedMadera(int ancho)
    {
        Ancho = ancho;
    }

    public override int ObtenerResistencia() => 25 * Ancho;
}