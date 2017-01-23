using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOProjekt.Interfejs.Komendy
{
    public class PrzykladK:IKomenda
    {
        public bool wykonaj()
        {
            Console.WriteLine("Przykladowa komenda");
            return false;
        }
    }
}
