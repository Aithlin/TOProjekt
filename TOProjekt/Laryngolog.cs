using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOProjekt
{
    class Laryngolog:Lekarz
    {
        public override void badaj(Pacjent pacjent)
        {
            Console.WriteLine("Laryngolog bada ucho.");
        }
    }
}
