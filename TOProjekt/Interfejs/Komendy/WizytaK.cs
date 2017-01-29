using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOProjekt.Interfejs.Komendy
{
    public class WizytaK:IKomenda
    {
        bool czyBlad = false;
        string imie, nazwisko, lekarz;

        public WizytaK(IEnumerable<string> polecenie) 
        {
            if(polecenie.Count() != 4)
            {
                czyBlad = true;
            }
            else
            {
                this.imie = polecenie.ElementAtOrDefault<string>(1);
                this.nazwisko = polecenie.ElementAtOrDefault<string>(2);
                this.lekarz = polecenie.ElementAtOrDefault<string>(3);
            }
        }

        public bool wykonaj()
        {
            if(czyBlad)
            {
                Console.WriteLine("Nieprawidlowa ilosc argumentow, poprawna skladnia: wizyta imie nazwisko lekarz");
            }
            else
            {
                Przychodnia.odbyciewizyty(imie, nazwisko, lekarz);
                return false;
            }

            return false;
        }
    }
}
