using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {   //objeto de la clase
            clsClientesVentas Cliente;
            //instancia de la clase
            Cliente = new clsClientesVentas();

            Cliente.IdClientes = 123;
            Cliente.Apellidos = "Pon Atencion";
            Cliente.Nombres = "Jose Luis";
            Cliente.RFC = "DSNMFSDF";
            Cliente.Direccion = "Inserte aqui la direccion de CESCA";
            Cliente.Municipio = "Tijuana es un Municipio? :/";
            Cliente.EsCredito = true; //true porque es un valor booleano y solo aceptan "true" o "false"

            Console.WriteLine(Cliente.IdClientes + "" + Cliente.Apellidos + " " + Cliente.Nombres);
            Console.WriteLine(Cliente.Direccion + " " + Cliente.Municipio);

            if (Cliente.EsCredito)
                Console.WriteLine("El cliente tiene credito");
            else
                Console.WriteLine("El cliente no tiene credito");
            Console.ReadKey();
        }
    }
}
