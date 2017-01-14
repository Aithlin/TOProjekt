using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOProjekt
{
    class Kardiolog:Lekarz
    {
        public Kardiolog(string imie, string nazwisko) : base(imie,nazwisko)
        {
        }
        public override void badaj(Pacjent pacjent)
        {
            Console.WriteLine("Kardiolog bada serce.");
        }
    }
}
