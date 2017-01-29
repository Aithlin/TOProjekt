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

        }

        protected override void badanie(Pacjent pacjent)
        {
            Console.WriteLine("Pulmunolog bada płuca.");
        }

        protected override void prezentacjaWynikow()
        {

        }

        protected override void zakonczenieWizyty()
        {

        }

        public override ELekarz typ()
        {
            return ELekarz.PULMUNOLOG;
        }
    }
}
