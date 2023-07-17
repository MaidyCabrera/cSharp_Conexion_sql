using Curso_Youtobe.Models;
using System;

namespace Curso_Youtube.Models
{
    internal class Vino : Bebida, IBebidaAlcoholica
    {
        public int Alcohol { get; set; }

        public Vino(int Cantidad, string Nombre = "Vino") : base(Nombre, Cantidad)
        {
        }

        public void MaxRecomendado()
        {
            Console.WriteLine("El máximo permitido son 3 copas");
        }
    }
}

