namespace AngryBirds.Biblioteca;


public class PajaroComun : Pajaro
{
    public PajaroComun(int iraInicial) : base(iraInicial) { }

    public override int ObtenerFuerza() => Ira * 2;
}