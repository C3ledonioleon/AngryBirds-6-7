using AngryBirds.Biblioteca.Models.Abstract;

namespace AngryBirds.Biblioteca.Models;

public class ParedPiedra : Obstaculo
{
    public int Ancho { get; set; }

    public ParedPiedra(int ancho)
    {
        Ancho = ancho;
    }

    public override int ObtenerResistencia() => 50 * Ancho;
}