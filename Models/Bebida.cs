using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleConsoleApp.Models
{
    public class Bebida
    {
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public int Cantidad { get; set; }

        public Bebida(string Nombre, string Marca, int Cantidad)
        {
            this.Nombre = Nombre;
            this.Marca = Marca;
            this.Cantidad = Cantidad;
        }
    }
}
