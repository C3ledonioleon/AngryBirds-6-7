using AngryBirds.Biblioteca.Models.Abstract;

namespace AngryBirds.Biblioteca.Models;

public class Chuck : Pajaro
{
    public double Velocidad { get; set; }

    public Chuck(int iraInicial, double velocidad) : base(iraInicial)
    {
        Velocidad = velocidad;
    }
    public override void Enojar()
    {
        base.Enojar();
        Velocidad *= 2;
    }

    public override int ObtenerFuerza()
    {
        if (Velocidad <= 80) return 150;
        return 150 + 5 * (int)(Velocidad - 80);
    }
}