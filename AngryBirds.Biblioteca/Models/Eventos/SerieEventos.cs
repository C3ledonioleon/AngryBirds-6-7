using AngryBirds.Biblioteca.Models.Abstract;

namespace AngryBirds.Biblioteca.Models;


public class SerieEventos : Evento
{
    public List<Evento> Eventos { get; private set; }

    public SerieEventos(List<Evento> eventos)
    {
        this.Eventos = eventos;
    }

    public override void Suceder(IslaPajaro islaPajaro)
    {
        foreach (var evento in Eventos)
        {
            evento.Suceder(islaPajaro);
        }
    }
}