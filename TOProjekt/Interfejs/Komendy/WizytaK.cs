using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOProjekt.Interfejs.Komendy
{
    public class WizytaK:IKomenda
    {
        string imie, nazwisko, lekarz;

        public WizytaK(string imie, string nazwisko, string lekarz) 
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.lekarz = lekarz;
        }

        public bool wykonaj()
        {
            Przychodnia.odbyciewizyty(imie, nazwisko, lekarz);
            return false;
        }
    }
}
