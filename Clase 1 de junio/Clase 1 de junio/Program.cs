using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_1_de_junio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //XXXXXXXXXX
            //X        X
            //X        X
            //X        X
            //XXXXXXXXXX

            Metodo1();

            Metodo2();

            Metodo3();

            Console. ReadKey();
        }

        static public void Metodo1()
        {
            Console.WriteLine("XXXXXXXXXX");
            Console.WriteLine("X        X");
            Console.WriteLine("X        X");
            Console.WriteLine("X        X");
            Console.WriteLine("XXXXXXXXXX");
        }
           static public void Metodo2()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.Write("X");
            }
            Console.WriteLine();
            for(int j = 0; j < 3; j++)
            {
                Console.WriteLine("X        X");
            }
            for (int i = 0; i < 10; i++)
            {
                Console.Write("X");
            }
            Console.WriteLine();
        }
       
       static public void Metodo3()
        {
            for (int i = 0;i < 5; i++)
            { 
                for (int k = 0; k < 10; k++)
                {
                    if (i == 0 || i == 4)
                    { 
                        Console.Write("X"); 
                    }
                    else
                    {
                        if (k == 0 || k == 9)
                        {
                            Console.Write("X");
                        }
                        else 
                        { 
                            Console.Write(" "); 
                        } 
                       /*Console.Write(" ");*/
                    }

                }
                Console.WriteLine() ;
            }
                

        }
    }
}
