using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOProjekt.Interfejs.Komendy
{
    public class RejestracjaK:IKomenda
    {
        string imie, nazwisko, lekarz;

        public RejestracjaK(string imie, string nazwisko, string lekarz) 
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.lekarz = lekarz;
        }

        public bool wykonaj()
        {
            Rejestracja.telefon(imie, nazwisko, lekarz);
            return false;
        }
    }
}
