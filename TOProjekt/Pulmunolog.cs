﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOProjekt
{
    class Pulmunolog:Lekarz
    {
        public Pulmunolog(string imie, string nazwisko) : base(imie,nazwisko)
        {
        }

        public override void badaj(Pacjent pacjent)
        {
            Console.WriteLine("Pulmunolog bada płuca.");
        }
    }
}
