using AngryBirds.Biblioteca.Models.Abstract;

namespace AngryBirds.Biblioteca.Models;


public class FiestaSorpresa : Evento
{
    private List<Pajaro> homenajeados;

    public FiestaSorpresa(List<Pajaro> homenajeados)
    {
        this.homenajeados = homenajeados;
    }

    public override void Aplicar(IslaPajaro isla)
    {
        foreach (var pajaro in homenajeados)
        {
            pajaro.Enojar();
        }
    }
}