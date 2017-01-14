using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Kartoteka.getInstance().pacjenci.Add(new Pacjent("Dupencjusz", "Robak"));

            Rejestracja.telefon("Dupencjusz", "Pierdzioch");
            Rejestracja.telefon("Dupencjusz", "Robak");
        }
    }
}
