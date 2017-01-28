using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOProjekt.Interfejs.Komendy
{
    public class NicNieRobK:IKomenda
    {
        public bool wykonaj()
        {
            Console.WriteLine("Nie ma tu nic do zrobienia - jesli nie wiesz jakie masz komendy do wyboru wpisz help");
            return false;
        }
    }
}
