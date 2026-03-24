using AngryBirds.Biblioteca.Models.Abstract;

namespace AngryBirds.Biblioteca.Models;

public class InvasionCerditos : Evento
{
    public int Cantidad  {get; private set; }

    public InvasionCerditos(int cantidad)
    {
        this.Cantidad = cantidad;
    }

    public override void Suceder(IslaPajaro islaPajaro)
    {
        int veces = Cantidad / 100;

        foreach (var pajaro in islaPajaro.Pajaros)
        {
            for (int i = 0; i < veces; i++)
            {
                pajaro.Enojar();
            }
        }
    }
}