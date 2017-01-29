using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOProjekt.Interfejs.Komendy;

namespace TOProjekt.Interfejs
{
    class FabrykaKomendy
    {
        public static IKomenda StworzKomende(EKomenda ekomenda, List<string> polecenie)
        {
            switch (ekomenda)
            {
                case EKomenda.EXIT: return new ExitK();
                case EKomenda.HELP: return new HelpK();
                case EKomenda.REJESTRACJA: return new RejestracjaK(polecenie);
                case EKomenda.WIZYTA: return new WizytaK(polecenie.ElementAtOrDefault(1), polecenie.ElementAtOrDefault(2), polecenie.ElementAtOrDefault(3));
                case EKomenda.MOJEWIZYTY: return new MojeWizytyK(polecenie);
                default: return new NicNieRobK();
            }
        }
    }
}
