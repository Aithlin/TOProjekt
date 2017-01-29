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

        }

        protected override void przygotowaniePacjenta(Pacjent pacjent)
        {

        }

        protected override void badanie(Pacjent pacjent)
        {
            Console.WriteLine("Dermatolog bada skore.");
        }

        protected override void prezentacjaWynikow()
        {

        }

        protected override void zakonczenieWizyty()
        {

        }

        public override ELekarz typ()
        {
            return ELekarz.DERMATOLOG;
        }
    }
}
