using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOProjekt
{
    public abstract class Lekarz:Czlowiek
    {
        public Lekarz()
        {
        }
        public Lekarz(string imie, string nazwisko) : base(imie,nazwisko)
        {
        }
        public abstract void badaj(Pacjent pacjent);

        public void uzupelnijkartepacjenta(Pacjent pacjent)
        {
            Console.WriteLine("Wpisuje objawy pacjenta i ewentualne rozpoznanie choroby");
        }


        public abstract ELekarz typ();
    }
}
