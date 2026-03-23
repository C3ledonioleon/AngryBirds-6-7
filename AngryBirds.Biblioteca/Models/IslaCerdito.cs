namespace AngryBirds.Biblioteca.Models;

using System.Collections.Generic;
using System.Linq;
using AngryBirds.Biblioteca.Models.Abstract;

public class IslaCerdito
{
    public List<Obstaculo> Obstaculos { get; private set; }

    public IslaCerdito()
    {
        Obstaculos = new List<Obstaculo>();
    }

    public void AgregarObstaculo(Obstaculo obstaculo)
    {
        Obstaculos.Add(obstaculo);
    }

    public void RecibirAtaque(Pajaro pajaro)
    {
        if (!Obstaculos.Any())
            return;

        var obstaculo = Obstaculos.First();

        if (pajaro.ObtenerFuerza() > obstaculo.ObtenerResistencia())
        {
            Obstaculos.Remove(obstaculo);
        }
    }

    public bool EstaLibreDeObstaculos()
    {
        return !Obstaculos.Any();
    }
}