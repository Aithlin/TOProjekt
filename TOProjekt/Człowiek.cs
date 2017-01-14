using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOProjekt
{
    public class Człowiek
    {
        public string imie;
        public string nazwisko;
        public string telefon;

        public Człowiek()
        {

        }

        public Człowiek(string imie, string nazwisko, string telefon)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.telefon = telefon;
        }
    }
}
