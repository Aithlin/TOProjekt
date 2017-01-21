using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOProjekt
{
    public abstract class Lekarz:Człowiek
    {
        public Lekarz()
        {
        }
        public Lekarz(string imie, string nazwisko) : base(imie,nazwisko)
        {
        }
        public abstract void badaj(Pacjent pacjent);
        public void zakonczwizyte()
        {
            Console.WriteLine("Koniec wizyty.");
        }
    }
}
