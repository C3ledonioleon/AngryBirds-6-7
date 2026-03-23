namespace AngryBirds.Biblioteca;

public class CerditoConEscudo : Obstaculo
{
    public int ResistenciaEscudo { get; set; }

    public CerditoConEscudo(int resistenciaEscudo)
    {
        ResistenciaEscudo = resistenciaEscudo;
    }

    public override int ObtenerResistencia() => 10 * ResistenciaEscudo;
}