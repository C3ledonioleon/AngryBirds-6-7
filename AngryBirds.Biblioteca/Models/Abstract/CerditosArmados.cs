using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngryBirds.Biblioteca.Models.Abstract;

namespace AngryBirds.Biblioteca.Models.Obstaculos;
public abstract class CerditoConArmas : Obstaculo
{
    public int ResistenciaArma { get; set; }

    public CerditoConArmas(int resistenciaArma)
    {
        if (resistenciaArma <= 0)
            throw new ArgumentException("La resistencia debe ser mayor a 0");

        ResistenciaArma = resistenciaArma;
    }
}