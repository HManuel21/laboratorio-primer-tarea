using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejecicio2
{
    public class Vehiculo
    {
        protected string marca;
        protected string modelo;

     
        public Vehiculo()
        {
            marca = "Desconocida";
            modelo = "Desconocido";
        }


        public Vehiculo(string marca, string modelo)
        {
            this.marca = marca;
            this.modelo = modelo;
        }

  
        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Vehículo: {marca} {modelo}");
        }

          
        public static void MensajeGenerico()
        {
            Console.WriteLine("Este es un mensaje genérico desde Vehiculo");
        }
    }
}
