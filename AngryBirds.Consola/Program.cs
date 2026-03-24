using System;
using System.Collections.Generic;
using AngryBirds.Biblioteca.Models;
using AngryBirds.Biblioteca.Models.Abstract;

class Program
{
    static void Main()
    {
        // =========================
        // 1. CREAR ISLA DE PÁJAROS
        // =========================
        IslaPajaro islaPajaro = new IslaPajaro();

        var comun = new PajaroComun(10);
        var red = new Red(10);
        var bomb = new Bomb(9000);
        var chuck = new Chuck(10, 50);
        var matilda = new Matilda(20);

        islaPajaro.AgregarPajaro(comun);
        islaPajaro.AgregarPajaro(red);
        islaPajaro.AgregarPajaro(bomb);
        islaPajaro.AgregarPajaro(chuck);
        islaPajaro.AgregarPajaro(matilda);

        Console.WriteLine("=== FUERZA INICIAL ===");
        Console.WriteLine(islaPajaro.ObtenerFuerzaTotal());

        // =========================
        // 2. ENOJAR PÁJAROS
        // =========================
        Console.WriteLine("\n=== ENOJANDO PÁJAROS ===");

        comun.Enojar();
        red.Enojar();
        bomb.Enojar();
        chuck.Enojar();
        matilda.Enojar();

        Console.WriteLine("Fuerza después de enojarse:");
        Console.WriteLine(islaPajaro.ObtenerFuerzaTotal());

        // =========================
        // 3. EVENTOS
        // =========================
        Console.WriteLine("\n=== EVENTOS ===");

        Evento invasion = new InvasionCerditos(200);
        islaPajaro.SucedeEvento(invasion);

        Console.WriteLine("Después de invasión:");
        Console.WriteLine(islaPajaro.ObtenerFuerzaTotal());

        Evento fiesta = new FiestaSorpresa(new List<Pajaro> { red, chuck });
        islaPajaro.SucedeEvento(fiesta);

        Console.WriteLine("Después de fiesta:");
        Console.WriteLine(islaPajaro.ObtenerFuerzaTotal());

        // =========================
        // 4. ISLA CERDITO
        // =========================
        IslaCerdito islaCerdito = new IslaCerdito();

        islaCerdito.AgregarObstaculo(new ParedVidrio(2));
        islaCerdito.AgregarObstaculo(new ParedMadera(3));
        islaCerdito.AgregarObstaculo(new CerditoObrero());

        Console.WriteLine("\n=== ATAQUE ===");

        islaPajaro.Atacar(islaCerdito);

        Console.WriteLine("¿Quedan obstáculos?");
        Console.WriteLine(!islaCerdito.EstaLibreDeObstaculos());

        // =========================
        // 5. RESULTADO FINAL
        // =========================
        Console.WriteLine("\n=== RESULTADO FINAL ===");

        if (islaCerdito.EstaLibreDeObstaculos())
        {
            Console.WriteLine("¡Los pájaros recuperaron los huevos!");
        }
        else
        {
            Console.WriteLine("Los cerdos siguen resistiendo...");
        }
    }
}