using Curso_Youtobe.Models;
using System;

namespace Curso_Youtube.Models
{
    internal class Cerveza : Bebida, IBebidaAlcoholica
    {
        public int Alcohol { get; set; }
        public string Marca { get; set; }   

        public Cerveza(int Cantidad, string Nombre = "Cerveza") : base(Nombre, Cantidad)
        {
        }

        public void MaxRecomendado()
        {
            Console.WriteLine("Hola, soy el método MaxRecomendado");
        }
    }
}
