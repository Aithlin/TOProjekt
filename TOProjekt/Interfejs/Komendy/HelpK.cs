using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOProjekt.Interfejs.Komendy
{
    public class HelpK:IKomenda
    {
        public bool wykonaj()
        {
            Console.WriteLine("Dostepne komendy:");
            Console.WriteLine("Rejestracja");
            Console.WriteLine("Wizyta");
            Console.WriteLine("MojeWizyty");
            Console.WriteLine("Exit");
            return false;
        }

    }
}
