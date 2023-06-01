using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Clase_dia_1_6_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                MiNota(i);
            }

            GetMiNota(8);

            Console.ReadKey();
        }

        static public void GetMiNota(int nota)
        {
            string notaString = "";
            switch (nota)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                    notaString = "Suspendido";
                    break;
                case 5:
                case 6:
                    notaString = "Aprobado";
                    break;
                case 7:
                case 8:
                    notaString = "Notable";
                    break;
                case 9:
                case 10:
                    notaString = "Sobresaliente";
                    break;
                default:
                    notaString = "Valor no esperado";
                    break;
            }
            Console.WriteLine(notaString);
        }


        static public void MiNota(int nota)
        {
            //0 al 4: suspendido
            //5, 6: aprobado
            //7, 8: notable
            //9, 10: Sobresaliente
            //int nota = 8;

            Console.WriteLine("¿El alumno ha sacado...?");


            if (nota >= 0 && nota <= 4)
            {
                Console.WriteLine("Suspendido");
            }

            if (nota <= 6 && nota >= 5)
            {
                Console.WriteLine("Aprobado");
            }

            if (nota >= 7 && nota <= 8)
            {
                Console.WriteLine("Notable");
            }

            if (nota >= 9 && nota <= 10)
            {
                Console.WriteLine("Sobresaliente");
            }
        }



    }
}
