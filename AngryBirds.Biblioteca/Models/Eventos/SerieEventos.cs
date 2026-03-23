using AngryBirds.Biblioteca.Models.Abstract;

namespace AngryBirds.Biblioteca.Models;


public class SerieEventos : Evento
{
    private List<Evento> eventos;

    public SerieEventos(List<Evento> eventos)
    {
        this.eventos = eventos;
    }

    public override void Aplicar(IslaPajaro isla)
    {
        foreach (var evento in eventos)
        {
            evento.Aplicar(isla);
        }
    }
}