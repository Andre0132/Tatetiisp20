using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaTeTi_isp20
{
    class Program
    {
        static void Main(string[] args)
        {
            Juego juego = new Juego();
            int jugador_actual = 1;
            int ficha_actual = 1;
            while (true)
            {
                //llama al metodo pintar tablero de la clase juego
                juego.PintarTablero();
                if (ficha_actual == 0)
                {
                    Console.Write("Jugador {0}: Ingrese la posición de la ficha {1}", jugador_actual);
                    ficha_actual = Convert.ToInt32(Console.ReadLine());
                }
                //pide ingresar el movimiento
                Console.Write("Jugador {0}: Ingrese la posición de la ficha {1}",jugador_actual,ficha_actual);
                int posicion_elegida = Convert.ToInt32(Console.ReadLine());
                //almacenar el movimiento en el tablero y en las fichas del jugador
                juego.Jugar(jugador_actual, ficha_actual, posicion_elegida);
                //cambio de jugador
                jugador_actual++;
                if (jugador_actual == 3)
                {
                    jugador_actual = 1;
                    ficha_actual++;
                    if (ficha_actual == 4)
                        ficha_actual = 0;
                }

            }
            
        }
    }
}
