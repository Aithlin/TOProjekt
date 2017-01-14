﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            ustawDane();

            Rejestracja.telefon("Dupencjusz", "Pierdzioch");
            Rejestracja.telefon("Dupencjusz", "Robak");
        }

        static private void ustawDane()
        {
            //---------------------PACJENCI-----------------------
            Kartoteka.getInstance().pacjenci.Add(new Pacjent("Dupencjusz", "Robak"));

            //---------------------LEKARZE------------------------
            Kartoteka.getInstance().lekarze.Add(new Pulmunolog("Ronald", "Marek"));
        }
    }
}
