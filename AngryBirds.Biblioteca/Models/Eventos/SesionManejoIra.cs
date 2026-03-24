using AngryBirds.Biblioteca.Models.Abstract;

namespace AngryBirds.Biblioteca.Models;

public class SesionManejoIra : Evento
{
    public override void Suceder(IslaPajaro islaPajaro)
    {
        foreach (var pajaro in islaPajaro.Pajaros)
        {
            if (pajaro is not Chuck)
            {
                pajaro.IraInicial -= 5;
            }
        }
    }
}