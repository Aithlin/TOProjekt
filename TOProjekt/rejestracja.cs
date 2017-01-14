using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOProjekt
{
    class Rejestracja
    {
        static Wizyta zarejestruj(Pacjent pacjent,Lekarz lekarz, DateTime godzina)
        {
            Wizyta wizyta1 = new Wizyta(pacjent, lekarz, godzina);
            return wizyta1;
        }
    }
}
