using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea3.Clases;

namespace Tarea3
{
    class Program
    {
        static void Main(string[] args)
        {
            new cliente("Delgado Arcentales", "Santiago Patricio", 1316895075, "La Aurora").MostrarDatos();
            new gasolina("Extra", 5, 2.0).MostrarDatos();
            new gasolina("Extra", 5, 2.0).HacerCalculo();
            Console.ReadKey();
        }
    }
}
