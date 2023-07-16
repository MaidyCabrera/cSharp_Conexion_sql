using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Curso_Youtobe.Models;
using Curso_Youtube.Models;

namespace Curso_Youtobe
{
     class Program
    {
        static void Main(string[] args)
        {
            //Bebida bebida = new Bebida("Coca Cola", 1000);
            //bebida.Beberse(500);
            //Console.WriteLine(bebida.Cantidad);

            //var bebidaAlcoholica = new Vino(100);
            //MostrarRecomendacion(bebidaAlcoholica);
            //List<string> Hola = new List<string>();

            CervezaBD cervezaBD = new CervezaBD();

            //insertamos nueva cerveza
            {
                Cerveza cerveza = new Cerveza(15, "Aguila");
                cerveza.Marca = "Minerva";
                cerveza.Alcohol = 6;
                cervezaBD.Add(cerveza);
            }

            //Actualizar o editar una cerveza
            {
                Cerveza cerveza = new Cerveza(15, "Aguila");
                cerveza.Marca = "Minerva";
                cerveza.Alcohol = 6;
                cervezaBD.Edit(cerveza, 5);
            }

            //Eliminar una cerveza
            {
                cervezaBD.Delete( 5);
            }

            //Obtener todas las cervezas
            var cervezas = cervezaBD.Get();

            foreach (var cerveza in cervezas)
            {
                Console.WriteLine(cerveza);   
            }
            
        }

        static void MostrarRecomendacion(IBebidaAlcoholica bebida ) 
        {
            bebida.MaxRecomendado();

        }
    }
}
