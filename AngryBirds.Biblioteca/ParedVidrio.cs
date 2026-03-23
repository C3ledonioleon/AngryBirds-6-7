namespace AngryBirds.Biblioteca;

public class ParedVidrio : Obstaculo
{
    public int Ancho { get; set; }

    public ParedVidrio(int ancho)
    {
        Ancho = ancho;
    }

    public override int ObtenerResistencia() => 10 * Ancho;
}