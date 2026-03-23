using AngryBirds.Biblioteca.Models.Abstract;

namespace AngryBirds.Biblioteca.Models;

public class ParedVidrio : Obstaculo
{
    public int Ancho { get; set; }

    public ParedVidrio(int ancho)
    {
        Ancho = ancho;
    }

    public override int ObtenerResistencia() => 10 * Ancho;
}