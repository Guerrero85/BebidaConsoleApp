using ExampleConsoleApp.Models;


namespace ExampleConsoleApp
{
   class Program
    {
        static void Main(string[] args)
        {
           BebidaDB bebidaDB = new BebidaDB();

            /* {
                  Jugo Golden = new Jugo("Manzanita", "Palmalat", 300);
                  Golden.CantidadAzucar = 05;
                  bebidaDB.Add(Golden);
               }*/

            {
                Jugo Golden = new Jugo("Manzanita", "Palmalat", 10);
                Golden.CantidadAzucar = 10;
                bebidaDB.Edit(Golden, 4);
            }
            
           /* var jugos = bebidaDB.Get();
            foreach(var jugo in jugos)
            {
                Console.WriteLine(jugo.Nombre);
            }*/
        }

    }
}