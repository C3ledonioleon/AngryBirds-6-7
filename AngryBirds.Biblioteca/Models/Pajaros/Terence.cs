using AngryBirds.Biblioteca.Models.Abstract;

namespace AngryBirds.Biblioteca.Models;

public class Terence : Pajaro
{
    public int VecesEnojado { get; set; }
    public int Multiplicador { get; set; }

    public Terence(int iraInicial, int multiplicador) : base(iraInicial)
    {
        Multiplicador = multiplicador;
    }

    public override int ObtenerFuerza() => IraInicial* VecesEnojado * Multiplicador;
}