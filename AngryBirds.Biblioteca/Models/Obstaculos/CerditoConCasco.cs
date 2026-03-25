using AngryBirds.Biblioteca.Models.Abstract;
using AngryBirds.Biblioteca.Models.Obstaculos;

namespace AngryBirds.Biblioteca.Models;

public class CerditoConCasco : CerditoConArmas
{
    public CerditoConCasco(int resistenciaCasco)
        : base(resistenciaCasco)
    {
        
    }

    public override int ObtenerResistencia()
    {
        return 10 * ResistenciaArma;
    }
}