using System;
using System.Collections;
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

        public Człowiek(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            //this.telefon = telefon;
        }

        public override bool Equals(Object obj)
        {
            Człowiek człowiek = obj as Człowiek;
            if (człowiek == null)
                return false;

            return (imie.Equals(człowiek.imie) && nazwisko.Equals(człowiek.nazwisko));
        }

        public override string ToString()
        {
            return "imie: " + imie + " nazwisko: " + nazwisko;
        }

        public bool Equals(string imie, string nazwisko)
        {
            return (this.imie.Equals(imie) && this.nazwisko.Equals(nazwisko));
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
