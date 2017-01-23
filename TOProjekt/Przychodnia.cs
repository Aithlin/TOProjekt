﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOProjekt
{
    class Przychodnia
    {
        public static void odbyciewizyty(string imie, string nazwisko, string nazwalekarza)
        {
            Kartoteka kartoteka = Kartoteka.Instance;
            DateTime czas = DateTime.Now;

            Pacjent pacjent = kartoteka.pacjenci.Where(x => x.Equals(imie, nazwisko)).FirstOrDefault();
            if (pacjent == null)
            { 
                System.Console.WriteLine("Nie mam dla Pana/Pani wizyty, prosze sie zarejestrowac");
                return;
            }


            Wizyta wizyta = kartoteka.wizyty.Where(x=> x.pacjent==pacjent).Where(x=>x.godzina.Date==czas.Date).Where(x=>x.lekarz.typ()==ZwrocELekarza(nazwalekarza)).FirstOrDefault();
            if(wizyta==null)
            {
                System.Console.WriteLine("Nie ma dla Pana/Pani dzisiaj wizyty");
                return;
            }

            System.Console.WriteLine("Prosze wejsc do pokoju, badz zaczekac na swoja kolej");
            pacjent.podaniedanych();
            wizyta.lekarz.badaj(pacjent);
            wizyta.lekarz.uzupelnijkartepacjenta(pacjent);
            System.Console.WriteLine("Dziekujemy za wizyte");
        }

        private static ELekarz ZwrocELekarza(string elekarzstring)
        {
            ELekarz elekarz;

            if (Enum.TryParse<ELekarz>(elekarzstring.ToUpper(), out elekarz) == false) //lepszy bo nie trzeba robic wyjatkow
            {
                throw new NotImplementedException();
            }

            return elekarz;
        }
    }
}
