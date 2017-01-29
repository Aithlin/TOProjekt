using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOProjekt
{
    class Pulmunolog:Lekarz
    {
        public Pulmunolog(string imie, string nazwisko) : base(imie, nazwisko)
        {
        }

        protected override void przygotowanieSprzetu()
        {
            Console.WriteLine("Przygotowanie sprzetu do badan");
        }

        protected override void przygotowaniePacjenta(Pacjent pacjent)
        {
            Console.WriteLine("Pacjent sie rozbiera i wykonuje głębokie wdechy");
        }

        protected override void badanie(Pacjent pacjent)
        {
            Console.WriteLine("Pulmunolog bada płuca.");
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
            return ELekarz.PULMUNOLOG;
        }

        public override string ToString()
        {
            return base.ToString()+" Specjalizacja: Pulmunolog";
        }
    }
}
