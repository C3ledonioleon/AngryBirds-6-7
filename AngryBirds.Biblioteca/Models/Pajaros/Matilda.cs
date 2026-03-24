namespace AngryBirds.Biblioteca.Models;

using System.Collections.Generic;
using System.Linq;
using AngryBirds.Biblioteca.Models.Abstract;

public class Matilda : Pajaro
{
    public List<Huevo> Huevos { get; private set; }

    public Matilda(int iraInicial) : base(iraInicial)
    {
        Huevos = new List<Huevo>();
    }

    public override int ObtenerFuerza()
    {
        return IraInicial * 2 + Huevos.Sum(h => h.ObtenerFuerza());
    }

    public override void Enojar()
    {
        base.Enojar();
        Huevos.Add(new Huevo(2));
    }
}