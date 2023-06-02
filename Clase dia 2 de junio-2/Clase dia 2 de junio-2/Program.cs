using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_dia_2_de_junio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroAlumnos = 10;
            
            GenerarNotas(numeroAlumnos);
            SumarNotas(numeroAlumnos);
            MayorNota(numeroAlumnos);
            Console.WriteLine("Pulsa cualquier tecla para salir");
            Console.ReadKey();
        }

        //Metodo que nos dice cual es la mayor notaque se ha puesto
        //generando n notas aleatorias
        static public void MayorNota(int numeroAlumnosInterno)
        {
            int[] notas = new int[numeroAlumnosInterno];
            int numeroMayor = 0;

            Random rand = new Random();

            //Generar notas aleatoriamente y elegir el mayor
            for (int i = 0; i < numeroAlumnosInterno; i++)
            {
                notas[i] = rand.Next(10);
                if (numeroMayor < notas[i])
                    numeroMayor = notas[i];
                Console.Write(notas[i] + " ");
            }
            Console.WriteLine("La nota mas alta es: " + numeroMayor);

            //cuantas personas han sacado la mayor nota
            int cantidadDeNotasMayores = 0;
                for(int i = 0;i < numeroAlumnosInterno; i++)
                {
                    if (notas[i] == numeroMayor)
                    {
                        cantidadDeNotasMayores++;
                    }
                    
                }

            Console.WriteLine("La máxima nota ha aparecido " + cantidadDeNotasMayores + " veces");
        }

            
        static public void SumarNotas(int numeroAlumnosInterno)
        {
            int[] notas = new int[numeroAlumnosInterno];
            int[] notas2 = new int[numeroAlumnosInterno];

            Random rand = new Random();

            for (int i = 0; i < numeroAlumnosInterno; i++)
            {
                notas[i] = rand.Next(10);
                notas2[i] = rand.Next(10); //genera un número aleatorio
            }
        }
        static public void GenerarNotas(int numeroAlumnosInterno)
        {
            int[] notas = new int[numeroAlumnosInterno];
            int suma = 0;
            int media = 0;

            Random random = new Random();
           // int valor = random.Next(10);
            
            //Generar las notas aleatoriamente, imprimirlas y sumarlas
            for (int i = 0; i < numeroAlumnosInterno; i++) 
            {
                notas[i] = random.Next(10);
                Console.WriteLine(notas[i]);
                suma = suma + notas[i];
                media = suma / numeroAlumnosInterno;

            }
            //Suma todas las notas
            /*for (int i = 0;i < numeroAlumnosInterno;i++) 
            {
               suma = suma + notas[i];
            }*/
            Console.WriteLine("Suma de todas las notas: " + suma);
            Console.WriteLine("Nota Media: " + media);
        }

    }
}
