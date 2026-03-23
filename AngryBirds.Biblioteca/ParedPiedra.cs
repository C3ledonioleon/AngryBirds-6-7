namespace AngryBirds.Biblioteca;

public class ParedPiedra : Obstaculo
{
    public int Ancho { get; set; }

    public ParedPiedra(int ancho)
    {
        Ancho = ancho;
    }

    public override int ObtenerResistencia() => 50 * Ancho;
}