﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOProjekt
{
    class Okulista : Lekarz
    {
        public Okulista(string imie, string nazwisko) : base(imie,nazwisko)
        {
        }
        public override void badaj(Pacjent pacjent)
        {
            Console.WriteLine("Okulista bada oko.");
        }
    }
}
