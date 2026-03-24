using AngryBirds.Biblioteca.Models.Abstract;

namespace AngryBirds.Biblioteca.Models;

public class IslaPajaro
{
    public List<Pajaro> Pajaros { get; private set; }

    public IslaPajaro()
    {
        Pajaros = new List<Pajaro>();
    }

    public void AgregarPajaro(Pajaro pajaro)
    {
        Pajaros.Add(pajaro);
    }

    public List<Pajaro> ObtenerPajarosFuertes()
    {
        return Pajaros.Where(p => p.ObtenerFuerza() > 50).ToList();
    }

    public int ObtenerFuerzaTotal()
    {
        return ObtenerPajarosFuertes().Sum(p => p.ObtenerFuerza());
    }

    public void AplicarEvento(Evento evento)
    {
        evento.Suceder(this);
    }

    public void Atacar(IslaCerdito islaCerdito)
    {
        foreach (var pajaro in Pajaros)
        {
            islaCerdito.RecibirAtaque(pajaro);
        }
    }
}