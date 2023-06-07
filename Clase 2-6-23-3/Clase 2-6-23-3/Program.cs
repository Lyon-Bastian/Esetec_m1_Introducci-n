using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_2_6_23_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int puntos = 0;
            Random random = new Random();

            puntos = random.Next(200);

            Console.WriteLine(puntos);

            //Si tienes mas de 50 puntos escribe "gané" y si no, escribe "Perdí"
            if (puntos >= 100) 
            {
                Console.WriteLine("Perfecto!");           
            }
            
                       //si esta entre 30 y 50 escribe "Casi superado"
            if (puntos > 30 && puntos < 50)
            {
                Console.WriteLine("Casi superado");
            }

            if (puntos >= 50)
            {
                Console.WriteLine("Gané");
            }

            if (puntos != 0)
            {
                Console.WriteLine("Tienes algo de puntuación");
            }

            if (puntos >=60 && puntos <=70)
            {
                Console.WriteLine("Bastante bien");
            }

            if (puntos < 50)
            {
                Console.WriteLine("Perdí");
            }









            Console.ReadKey();
        }
    }
}
