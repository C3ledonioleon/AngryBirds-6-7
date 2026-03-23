using AngryBirds.Biblioteca.Models.Abstract;

namespace AngryBirds.Biblioteca.Models;

public class InvasionCerditos : Evento
{
    private int cantidad;

    public InvasionCerditos(int cantidad)
    {
        this.cantidad = cantidad;
    }

    public override void Aplicar(IslaPajaro isla)
    {
        int veces = cantidad / 100;

        foreach (var pajaro in isla.Pajaros)
        {
            for (int i = 0; i < veces; i++)
            {
                pajaro.Enojar();
            }
        }
    }
}