using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOProjekt.Interfejs.Komendy
{
    class MojeWizytyK : IKomenda
    {
        bool czyBlad = false;
        string imie, nazwisko;

         public MojeWizytyK(IEnumerable<string> polecenie) 
        {
            if(polecenie.Count() != 3)
            {
                czyBlad = true;
            }
            else
            {
                this.imie = polecenie.ElementAtOrDefault<string>(1);
                this.nazwisko = polecenie.ElementAtOrDefault<string>(2);
            }
        }

        public bool wykonaj()
        {
            if (czyBlad)
            {
                Console.WriteLine("Nieprawidlowa ilosc argumentow, poprawna skladnia: Mojewizyty imie nazwisko");
            }
            else
            {
                Przychodnia.MojeWizyty(imie, nazwisko);
            }

            return false;
        }
    }
}
