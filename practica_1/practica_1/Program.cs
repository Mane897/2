using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string persona;
            string dias;
            int b;
            int c;
            Console.Write("Ingrese su nombre");
            persona = Console.ReadLine();
            Console.Write("Ingrese los dias que ha trabajado");
            dias = Console.ReadLine();
            b = int.Parse(dias);
            c = b * 200;
            Console.WriteLine(persona + " su sueldo a cobrar es " + c);
            Console.ReadKey();
        }
    }
}
