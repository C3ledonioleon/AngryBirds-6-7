using AngryBirds.Biblioteca.Models.Abstract;

namespace AngryBirds.Biblioteca.Models;

public class Bomb : Pajaro
{
    public int TopeFuerza { get; set; }

    public Bomb(int iraInicial, int topeFuerza = 9000) : base(iraInicial)
    {
        TopeFuerza = topeFuerza;
    }

    public override int ObtenerFuerza()
    {
        int fuerza = IraInicial * 2;

        return fuerza > TopeFuerza ? TopeFuerza : fuerza;
    }
}                                                                                                                 