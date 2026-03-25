

namespace AngryBirds.Biblioteca.Models.Abstract;
public abstract class Pajaro
{
    public int IraInicial { get; set; }

    protected Pajaro(int iraInicial)
    {
        IraInicial = iraInicial;
    }

    public abstract int ObtenerFuerza();

    public virtual void Enojar()
    {
        IraInicial *= 2;
    }

}