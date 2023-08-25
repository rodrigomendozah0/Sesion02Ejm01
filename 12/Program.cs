using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad;
            Console.WriteLine("Ingresa tu edad: "); 
            edad = int.Parse(Console.ReadLine());
            if (edad >= 18)
            {
                Console.WriteLine("Usted es mayor de edad");
            }
            else 
            {
                Console.WriteLine("Usted es menor de edad");
            }
        }
    }
}
