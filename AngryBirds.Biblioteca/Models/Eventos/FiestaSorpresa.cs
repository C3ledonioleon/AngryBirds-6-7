using AngryBirds.Biblioteca.Models.Abstract;

namespace AngryBirds.Biblioteca.Models;


public class FiestaSorpresa : Evento
{
    public   List<Pajaro> Homenajeados  { get; private set; }

    public FiestaSorpresa(List<Pajaro> homenajeados)
    {
        this.Homenajeados = homenajeados;
    }

    public override void Suceder(IslaPajaro islaPajaro)
    {
        foreach (var pajaro in Homenajeados)
        {
            pajaro.Enojar();
        }
    }
}