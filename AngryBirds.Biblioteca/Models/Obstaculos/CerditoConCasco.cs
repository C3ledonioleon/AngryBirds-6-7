using AngryBirds.Biblioteca.Models.Abstract;

namespace AngryBirds.Biblioteca.Models;

public class CerditoConCasco : Obstaculo
{
    public int ResistenciaCasco { get; set; }

    public CerditoConCasco(int resistenciaCasco)
    {
        ResistenciaCasco = resistenciaCasco;
    }

    public override int ObtenerResistencia() => 10 * ResistenciaCasco;
}