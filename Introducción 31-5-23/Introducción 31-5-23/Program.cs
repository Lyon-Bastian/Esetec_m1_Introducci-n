using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introducción_31_5_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //tabla de multiplicar de un número

            int tabla = 7;

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(tabla + " * " + i + " = " + (tabla * i));
            }
            
            tabla = 5;

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(tabla + " * " + i + " = " + (tabla * i));
            }
            */
            //Todas las tablas

           /* int tabla = 7;

            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    Console.WriteLine(i + " * " + j + " = " + (j * i));
                }
            }*/
            
            //Distinguiendo entre pares e impares

            for (int i = 0; i <= 10; i++) 
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Par: " + i);
                }
                else
                {
                    Console.WriteLine("Impar: " + i);
                }
            }

            Console.WriteLine("Pulsa una tecla para cerrar");
            Console.ReadKey();
        }
    }
}
