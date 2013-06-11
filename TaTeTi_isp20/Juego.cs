using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaTeTi_isp20
{
   
    public class Juego
    {
        private Tablero tablero;
        private Jugador jugador1;
        private Jugador jugador2;

        public Juego()
        {
            tablero = new Tablero();
            jugador1 = new Jugador("X");
            jugador2 = new Jugador("O");
    }
        public void PintarTablero()
        {
            tablero.Pintar();
        }
        public void Jugar(int jugador, int nroficha, int pos_elegida)
        {
            //almacena cada uno de los jugadores en las posiciones elegidas
            if (jugador==1)
                jugador1.fichas[nroficha]=pos_elegida;
            else
                jugador2.fichas[nroficha] = pos_elegida;
            foreach(int pos_ficha in jugador1.fichas)
            {
                tablero.posiciones[pos_ficha] = jugador1.tipo_ficha;
            }
            foreach (int pos_ficha in jugador2.fichas)
            
            }
    }
}
