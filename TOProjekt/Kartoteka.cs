using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOProjekt
{
    class Kartoteka
    {
        public HashSet<Pacjent> pacjenci = new HashSet<Pacjent>();
        public HashSet<Lekarz> lekarze = new HashSet<Lekarz>();

        public HashSet<Wizyta> wizyty = new HashSet<Wizyta>();


        private static Kartoteka kartoteka;

        private Kartoteka() { }

        public static Kartoteka getInstance()
        {
            if(kartoteka == null)
            {
                kartoteka = new Kartoteka();
            }

            return kartoteka;
        }
    }
}
