using AngryBirds.Biblioteca.Models.Abstract;

namespace AngryBirds.Biblioteca.Models;

public class CerditoConEscudo : Obstaculo
{
    public int ResistenciaEscudo { get; set; }

    public CerditoConEscudo(int resistenciaEscudo)
    {
        ResistenciaEscudo = resistenciaEscudo;
    }

    public override int ObtenerResistencia() => 10 * ResistenciaEscudo;
}