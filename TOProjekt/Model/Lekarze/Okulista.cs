using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOProjekt
{
    class Okulista : Lekarz
    {
        public Okulista(string imie, string nazwisko) : base(imie, nazwisko)
        {
        }

        protected override void przygotowanieSprzetu()
        {
            Console.WriteLine("Przygotowanie sprzetu do badan");
        }

        protected override void przygotowaniePacjenta(Pacjent pacjent)
        {
            Console.WriteLine("Lekarz zakrapia oczy pacjeta.");
        }

        protected override void badanie(Pacjent pacjent)
        {
            Console.WriteLine("Okulista bada dno oka.");
        }

        protected override void prezentacjaWynikow()
        {
            Console.WriteLine("Lekarz przedstawia wyniki badan i ewentualnie przepisuje okulary");
        }

        protected override void zakonczenieWizyty()
        {
            Console.WriteLine("Pacjent wychodzi");
        }

        public override ELekarz typ()
        {
            return ELekarz.OKULISTA;
        }

        public override string ToString()
        {
            return base.ToString() + " Specjalizacja: Okulista";
        }
    }
}
