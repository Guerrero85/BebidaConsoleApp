using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleConsoleApp.Models
{
    internal class Jugo : Bebida, IBebidaAzucarada
    {
        public int CantidadAzucar { get; set; }
        public void MaxRecomendado()
        {
            Console.WriteLine("Maximo Recomendado 10g de azucar");
        }
        public Jugo(string Nombre, string Marca, int Cantidad) : base(Nombre, Marca, Cantidad)
        {

        }
    }
}
