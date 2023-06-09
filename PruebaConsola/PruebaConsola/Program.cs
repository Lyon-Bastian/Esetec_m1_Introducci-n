using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Alejandro Díaz Miranda

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            
            int suma;

            Console.WriteLine("Hola desde Esetec");

            int valor1 = 6;
            int valor2 = 6;
            suma = valor1 + valor2;
                                  
            Console.WriteLine(suma);

            //Por desgracia no recuerdo como colocar los números correlativos en horizontal sin añadir tambien la primera linea de la siguiente función
            NumerosCorrelativos();

            TablaDel5();

            Console.WriteLine("Pulsa una tecla para cerrar");
            Console.ReadKey();
        }

        static public void NumerosCorrelativos()
        {
            int listaNumeros;

            for (int i = 1;  i <= 20; i++)
            {
                Console.WriteLine(i.ToString() + " ");

            }
        }

        static public void TablaDel5()
        {
            int tabla = 9;

            Console.WriteLine("Tabla del " + tabla);

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(tabla + " * " + i + " = " + (tabla * i));
            }
            
        }
    }
}
