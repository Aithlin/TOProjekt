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
            // zamiana napisu na polecenie (trzymane w tablicy)
           List<string> polecenie = new List<string>(napis.Split());
           EKomenda ekomenda;

           if (Enum.TryParse<EKomenda>(polecenie.FirstOrDefault().ToUpper(), out ekomenda) == false) //lepszy bo nie trzeba robic wyjatkow
           {
                ekomenda = EKomenda.NONE;
           }

           return FabrykaKomendy.StworzKomende(ekomenda, polecenie);
       }
    }
}
