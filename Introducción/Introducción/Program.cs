using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introducción
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
            //Imprimir en pantalla los números pares del 0 al 10

             for(int i = 0; i  <= 10; i = i + 2 )
             {
                 Console.WriteLine(i);
             }


             for (int i = 1; i <=10; i = i + 2)
             {
                 Console.WriteLine(i);
             }

             */

            //Factorial de 5
            /*
            int resultado = 1;
            for (int i = 5; i >= 1; i--)

            {
                resultado = i * resultado;
            }
            Console.WriteLine(resultado);
            */

            //sumatoria
            int resultado = 0;
            for (int i = 0; i <=10;  i++)
            {
                resultado = i + resultado;
            }
            Console.WriteLine(resultado);

            Console.WriteLine("Presiona Enter para cerrar la ventana");

            Console.ReadKey();
        }
    }
}
