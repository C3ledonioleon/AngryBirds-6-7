using System;
using AngryBirds.Biblioteca.Models;
using AngryBirds.Biblioteca.Models.Abstract;

class Program
{
    static void Main()
    {
        // Crear isla de pájaros
        IslaPajaro islaPajaro = new IslaPajaro();

        // Crear pájaros
        PajaroComun p1 = new PajaroComun(10);
        Bomb bomb = new Bomb(5000);
        Matilda matilda = new Matilda(20);

        islaPajaro.AgregarPajaro(p1);
        islaPajaro.AgregarPajaro(bomb);
        islaPajaro.AgregarPajaro(matilda);

        Console.WriteLine("Fuerza total inicial: " + islaPajaro.ObtenerFuerzaTotal());

        // Crear isla de cerditos
        IslaCerdito islaCerdito = new IslaCerdito();

        islaCerdito.AgregarObstaculo(new ParedVidrio(2));
        islaCerdito.AgregarObstaculo(new CerditoObrero());

        // Ataque
        islaPajaro.Atacar(islaCerdito);

        Console.WriteLine("¿Quedan obstáculos?: " + !islaCerdito.EstaLibreDeObstaculos());

        // Evento
        Evento invasion = new InvasionCerditos(200);
        islaPajaro.AplicarEvento(invasion);

        Console.WriteLine("Fuerza después de invasión: " + islaPajaro.ObtenerFuerzaTotal());
    }
}