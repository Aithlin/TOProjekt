using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOProjekt.Interfejs.Komendy;

namespace TOProjekt.Interfejs
{
    public static class Parser
    {
       public static IKomenda parsuj(string napis)
       {
           List<string> polecenie = new List<string>( napis.Split());
           EKomenda ekomenda;

           if (Enum.TryParse<EKomenda>(polecenie.FirstOrDefault().ToUpper(), out ekomenda) == false) //lepszy bo nie trzeba robic wyjatkow
           {
               return new PrzykladK();
           }

           switch (ekomenda)
           {
               case EKomenda.EXIT: return new ExitK();
               case EKomenda.PRZYKLAD: return new PrzykladK();
               default: return new PrzykladK();
           }
       }
    }
}
