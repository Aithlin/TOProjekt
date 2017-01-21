using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOProjekt
{
    class Wizyta
    {
        public DateTime godzina;
        public Pacjent pacjent;
        public Lekarz lekarz;
        
        public Wizyta(Pacjent pacjent,Lekarz lekarz, DateTime godzina)
        {
            this.pacjent = pacjent;
            this.lekarz = lekarz;
            this.godzina = godzina;
        }

        void badanie()
        {
            pacjent.podaniedanych();
            lekarz.badaj(pacjent);
            lekarz.zakonczwizyte();
        }

        public String ToString()
        {
            return
                "Pacjent: " + pacjent.ToString() + " " +
                "Lekarz: " + lekarz.ToString() + " " +
                "Data: " + godzina.ToString() + " ";
        }
    }
}
