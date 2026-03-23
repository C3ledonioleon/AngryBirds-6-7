
namespace AngryBirds.Biblioteca.Models.Abstract;
public abstract class Pajaro
{
    public int Ira { get; set; }
    protected int VecesEnojado { get; set; }

    protected Pajaro(int iraInicial)
    {
        Ira = iraInicial;
        VecesEnojado = 0;
    }

    public abstract int ObtenerFuerza();

    public virtual void Enojar()
    {
        Ira *= 2;
        VecesEnojado++;
    }
}