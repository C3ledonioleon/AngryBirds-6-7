using AngryBirds.Biblioteca.Models.Abstract;

namespace AngryBirds.Biblioteca.Models;

public class SesionManejoIra : Evento
{
    public override void Suceder(IslaPajaro isla)
    {
        foreach (var pajaro in isla.Pajaros)
        {
            if (pajaro is not Chuck)
            {
                pajaro.IraInicial -= 5;
            }
        }
    }
}