using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleConsoleApp.Models
{
    internal interface IBebidaAzucarada
    {
        public int CantidadAzucar { get; set; }
        public void MaxRecomendado();
    }
}
