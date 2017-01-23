using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOProjekt
{
    class Dermatolog:Lekarz
    {
        public Dermatolog(string imie, string nazwisko) : base(imie,nazwisko)
        {
        }
        public override void badaj(Pacjent pacjent)
        {
            Console.WriteLine("Dermatolog bada skore.");
        }
        public override ELekarz typ()
        {
            return ELekarz.DERMATOLOG;
        }
    }
}
