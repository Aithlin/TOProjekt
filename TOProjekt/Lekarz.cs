using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOProjekt
{
    public abstract class Lekarz:Człowiek
    {
        public abstract void badaj(Pacjent pacjent);
        public void zakonczwizyte()
        {
            Console.WriteLine("Koniec wizyty.");
        }
    }
}
