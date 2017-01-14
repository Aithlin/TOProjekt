using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOProjekt
{
    class Rejestracja
    {
        public static void telefon(string imie, string nazwisko)
        {
            Pacjent pacjent = Kartoteka.getInstance().pacjenci.Where(x => x.Equals(imie, nazwisko)).FirstOrDefault();
            if(pacjent == null)
            {
                System.Console.WriteLine("Nie znaleziony: " + imie + " " + nazwisko);
                pacjent = new Pacjent(imie, nazwisko);
                Kartoteka.getInstance().pacjenci.Add(pacjent);
            }
            else
            {
                System.Console.WriteLine("Znaleziony: " + imie + " " + nazwisko);
            }

            System.Console.WriteLine("Obsluguje pacjenta: " + pacjent.ToString());
        }
        public static Wizyta zarejestruj(Pacjent pacjent,Lekarz lekarz, DateTime godzina)
        {
            Wizyta wizyta1 = new Wizyta(pacjent, lekarz, godzina);
            return wizyta1;
        }
    }
}
