﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace TaTeTi_isp20
{
    public class Jugador
    {
        public Hashtable fichas;
        public string tipo_ficha;

        public Jugador(string tipoficha)
        {
            fichas = new Hashtable();
            fichas.Add(1, 0);
            fichas.Add(2, 0);
            fichas.Add(3, 0);
            tipo_ficha = tipoficha;


        }
    }
}
