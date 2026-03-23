using AngryBirds.Biblioteca.Models.Abstract;

namespace AngryBirds.Biblioteca.Models;

public class Red : Pajaro
{
    public Red(int iraInicial) : base(iraInicial) { }

    public override int ObtenerFuerza() => Ira * 10 * VecesEnojado;
}