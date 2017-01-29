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

        public IEnumerable<Lekarz> dermatolodzy { get { return lekarze.OfType<Dermatolog>(); } } // definiuje get dla dermatologow, wyciagam ich z wszystkich lekarzy
        public IEnumerable<Lekarz> kardiolodzy { get { return lekarze.OfType<Kardiolog>(); } }
        public IEnumerable<Lekarz> laryngolodzy { get { return lekarze.OfType<Laryngolog>(); } }
        public IEnumerable<Lekarz> okulisci { get { return lekarze.OfType<Okulista>(); } }
        public IEnumerable<Lekarz> pulmunolodzy { get { return lekarze.OfType<Pulmunolog>(); } }

        public HashSet<Lekarz> lekarze = new HashSet<Lekarz>(); 
        public HashSet<Wizyta> wizyty = new HashSet<Wizyta>();

        private static Kartoteka kartoteka;
        public static Kartoteka Instance
        {
            get
            {
                if (kartoteka == null)
                {
                    kartoteka = new Kartoteka();
                }

                return kartoteka;
            }
        }
        private Kartoteka() { }
    }
}
