using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace TaTeTi_isp20
{
    public class Tablero
    {
        //hashtable: es una clase q nos permite manejar diccionario de datos
        
        public Hashtable posiciones;
        public Tablero()
        {
            //inicializa la variable posiciones
            posiciones = new Hashtable();
            for (int i = 1; i < 10; i++)
            //agregar la posicion i y decirle q no tiene valores
            posiciones.Add(i, " ");
        }
        public void Limpiar()
        { }
        public void Marcar(int jugador, int pos_elegida)
        { 
        }
        public void Pintar()
        {
            //borro la consola
            Console.Clear();
            //imprimo el tablero en cada una de las posiciones con su respectivo valor. inicializamos 
            // las 9 posiciones con el valor vacío
            for(int i = 1; i < 10; i++) 
            {
                Console.Write("[{0}]", posiciones[i]);
                //%:el modulo es la operacion q te da el resto de una division. 
                //utilizamos el modulo para detectar q ya se imprimieron 3 casilleros y generamos
                //un salto de linea
                if (i % 3 == 0)
                {
                    Console.Write("\n");
                }
            }
        }
    }
}
