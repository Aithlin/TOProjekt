using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOProjekt
{
    class Laryngolog:Lekarz
    {
        public Laryngolog(string imie, string nazwisko) : base(imie, nazwisko)
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
            Console.WriteLine("Laryngolog bada ucho.");
        }

        protected override void prezentacjaWynikow()
        {

        }

        protected override void zakonczenieWizyty()
        {

        }

        public override ELekarz typ()
        {
            return ELekarz.LARYNGOLOG;
        }
    }
}
