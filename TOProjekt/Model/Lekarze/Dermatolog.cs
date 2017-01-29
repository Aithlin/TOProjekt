using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOProjekt
{
    class Dermatolog:Lekarz
    {
        public Dermatolog(string imie, string nazwisko) : base(imie, nazwisko)
        {
        }

        protected override void przygotowanieSprzetu()
        {
            Console.WriteLine("Przygotowanie sprzetu do badan");
        }

        protected override void przygotowaniePacjenta(Pacjent pacjent)
        {
            Console.WriteLine("Pacjent odslania miejsce ktore chce zbadac.");
        }

        protected override void badanie(Pacjent pacjent)
        {
            Console.WriteLine("Dermatolog bada skore.");
        }

        protected override void prezentacjaWynikow()
        {
            Console.WriteLine("Lekarz przedstawia wyniki badan i ewentualnie przepisuje leki");
        }

        protected override void zakonczenieWizyty()
        {
            Console.WriteLine("Pacjent sie ubiera i wychodzi");
        }

        public override ELekarz typ()
        {
            return ELekarz.DERMATOLOG;
        }

        public override string ToString()
        {
            return base.ToString() + " Specjalizacja: Dermatolog";
        }
    }
}
