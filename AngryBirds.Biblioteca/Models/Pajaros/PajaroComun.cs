using AngryBirds.Biblioteca.Models.Abstract;

namespace AngryBirds.Biblioteca.Models;


public class PajaroComun : Pajaro
{
    public PajaroComun(int iraInicial) : base(iraInicial) { }

    public override int ObtenerFuerza() => Ira * 2;
}