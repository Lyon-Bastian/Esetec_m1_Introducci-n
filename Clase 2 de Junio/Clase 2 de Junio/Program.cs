using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_2_de_Junio
{
    internal class Program
    {
        static void Main(string[] args)
        {//Creando un codico con un "array" o matriz
            int numeroAlumnos = 10;
            int[] notas = new int[10];
            int suma = 0;
            notas[0] = 4;
            notas[1] = 5;
            notas[2] = 6;
            notas[3] = 8;
            notas[4] = 7;
            notas[5] = 9;

            //Console.WriteLine(notas[0]);

            for (int i = 0; i < numeroAlumnos; i++) //<---- los "for" se usan como intervalos
            {
                //Console.WriteLine(notas[i]);
                suma= suma + notas[i];
                
            }
            for (int i = 0;i < numeroAlumnos;i++) 
            {
                Console.WriteLine(notas[i]);
            }

            Console.WriteLine(suma);

            Console.ReadKey();
        }
    }
}
