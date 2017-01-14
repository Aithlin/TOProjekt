using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOProjekt
{
    public class Pacjent:Człowiek
    {
        public Pacjent(string imie, string nazwisko) : base(imie,nazwisko)
        {
        }

        public void podaniedanych()
        {
            Console.WriteLine("Pacjent sie przedstawia.");
        }

    }
}
