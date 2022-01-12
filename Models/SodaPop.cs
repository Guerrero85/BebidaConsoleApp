
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleConsoleApp.Models
{
    internal class SodaPop : Bebida, IBebidaAzucarada
    {
        public int CantidadAzucar { get; set; }
        public void MaxRecomendado()
        {
            Console.WriteLine("Maximo Recomendado 30g de azucar");
        }
        public SodaPop(string Nombre, string Marca, int Cantidad) : base(Nombre, Marca, Cantidad)
        {

        }
    }
}
