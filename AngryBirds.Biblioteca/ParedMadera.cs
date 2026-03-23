namespace AngryBirds.Biblioteca;

public class ParedMadera : Obstaculo
{
    public int Ancho { get; set; }

    public ParedMadera(int ancho)
    {
        Ancho = ancho;
    }

    public override int ObtenerResistencia() => 25 * Ancho;
}