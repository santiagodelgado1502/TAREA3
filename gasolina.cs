using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea3.Inteface;

namespace Tarea3.Clases
{
    public class gasolina:ICalculo,IDatos
    {
        private string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        private double cantidadGalones;

        public double CantidadGalones
        {
            get { return cantidadGalones; }
            set { cantidadGalones = value; }
        }
        private double precioVenta;

        public double PrecioVenta
        {
            get { return precioVenta; }
            set { precioVenta = value; }
        }

        public gasolina(string tipo, double cantidadGalones, double precioVenta)
        {
            Tipo = tipo;
            CantidadGalones = cantidadGalones;
            PrecioVenta = precioVenta;
        }

        public void HacerCalculo()
        {
            Double precio = 0;
            if (tipo=="Extra"||tipo=="extra")
            {
                precio = 1.5;
                double Subtotal = precio * cantidadGalones;
                double IVA= (precio*cantidadGalones)*12 / 100;
                double Total = Subtotal + IVA;

                Console.WriteLine("Subtotal: "+Subtotal);
                Console.WriteLine("IVA: "+IVA);
                Console.WriteLine("Total:"+Total);

            }
            else
            {
                precio = 2.0;
                double Subtotal = precio * cantidadGalones;
                double IVA = (precio * cantidadGalones) * 12 / 100;
                double Total = Subtotal + IVA;

                Console.WriteLine("Subtotal: " + Subtotal);
                Console.WriteLine("IVA: " + IVA);
                Console.WriteLine("Total:" + Total);
            }

        }

        public void MostrarDatos()
        {
            Console.WriteLine("Tipo de gasolina: "+tipo);
            Console.WriteLine("Cantidad de Galones:  "+cantidadGalones);
            Console.WriteLine("Precio de venta: "+precioVenta);
        }
    }
}
