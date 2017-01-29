using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOProjekt
{
    public abstract class Lekarz:Czlowiek
    {
        public Lekarz()
        {
        }

        public Lekarz(string imie, string nazwisko) : base(imie, nazwisko)
        {
        }

        public void obslugaWizyty(Pacjent pacjent)
        {
            przygotowanieSprzetu();
            przygotowaniePacjenta(pacjent);
            badanie(pacjent);
            prezentacjaWynikow();
            uzupelnienieKartyPacjenta(pacjent);
            zakonczenieWizyty();
        }

        protected abstract void przygotowanieSprzetu();
        protected abstract void przygotowaniePacjenta(Pacjent pacjent);
        protected abstract void badanie(Pacjent pacjent);
        protected abstract void prezentacjaWynikow();
        public void uzupelnienieKartyPacjenta(Pacjent pacjent)
        {
            Console.WriteLine("Wpisuje objawy pacjenta i ewentualne rozpoznanie choroby");
        }
        protected abstract void zakonczenieWizyty();




        public abstract ELekarz typ();
    }
}
