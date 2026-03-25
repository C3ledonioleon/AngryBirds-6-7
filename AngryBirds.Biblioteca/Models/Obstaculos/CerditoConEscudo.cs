using AngryBirds.Biblioteca.Models.Abstract;
using AngryBirds.Biblioteca.Models.Obstaculos;

namespace AngryBirds.Biblioteca.Models;

public class CerditoConEscudo : CerditoConArmas
{
    public CerditoConEscudo(int resistenciaEscudo)
        : base(resistenciaEscudo)
    {
    }
    public override int ObtenerResistencia()
    {
        return 10 * ResistenciaArma;
    }
}