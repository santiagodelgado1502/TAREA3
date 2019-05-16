using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea3.Inteface;

namespace Tarea3.Clases
{
    public class cliente:IDatos
    {
        private string apellidos;

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        private string nombres;

        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        private int cedula;

        public int Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }
        private string direccion;

        public  string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public cliente(string apellidos, string nombres, int cedula, string direccion)
        {
            Apellidos = apellidos;
            Nombres = nombres;
            Cedula = cedula;
            Direccion = direccion;
        }

        public void MostrarDatos()
        {
            Console.WriteLine("Apellidos: "+apellidos);
            Console.WriteLine("Nombres: "+nombres);
            Console.WriteLine("Numero de Cedula: "+cedula);
            Console.WriteLine("Direccion: "+direccion);
            
        }
    }
}
