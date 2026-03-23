namespace AngryBirds.Biblioteca;

public class SesionManejoIra : Evento
{
    public override void Aplicar(IslaPajaro isla)
    {
        foreach (var pajaro in isla.Pajaros)
        {
            if (pajaro is not Chuck)
            {
                pajaro.Ira -= 5;
            }
        }
    }
}