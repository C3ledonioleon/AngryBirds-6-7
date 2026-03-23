namespace AngryBirds.Biblioteca;

using System.Collections.Generic;
using System.Linq;

public class Matilda : Pajaro
{
    public List<Huevo> Huevos { get; private set; }

    public Matilda(int iraInicial) : base(iraInicial)
    {
        Huevos = new List<Huevo>();
    }

    public override int ObtenerFuerza()
    {
        return Ira * 2 + Huevos.Sum(h => h.Fuerza);
    }

    public override void Enojar()
    {
        base.Enojar();
        Huevos.Add(new Huevo(2));
    }
}