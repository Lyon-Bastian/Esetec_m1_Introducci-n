using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_dia_5_de_junio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jugador jugador = new Jugador();

            jugador.nombre = "Alejandro";
            jugador.puntuacion = 0;

            jugador.SetPuntuacion(20);
            jugador.SetPuntuacion(10);

            jugador.ImprimirJugador();
            jugador.Mensaje();
            

            Perro perro = new Perro();
            perro.nombre = "Layka";
            perro.puntuacion = 0;

            perro.ImprimirJugador();
            perro.Mensaje();            

            Gato gato = new Gato();
            gato.nombre = "Bella";
            gato.puntuacion = 0;
            Random random = new Random();
            gato.SetPuntuacion(random.Next(10));

            gato.ImprimirJugador();
            gato.Mensaje();           
            

            Console.ReadKey();
        }
    }
}
