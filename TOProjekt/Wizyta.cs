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

        public override String ToString()
        {
            return
                "Pacjent: " + pacjent.ToString() + " " +
                "Lekarz: " + lekarz.ToString() + " " +
                "Data: " + godzina.ToString() + " ";
        }
    }
}
