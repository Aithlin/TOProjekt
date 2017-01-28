using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOProjekt
{
    class Rejestracja
    {
        public static void telefon(string imie, string nazwisko,string nazwalekarza)
        {
            Kartoteka kartoteka = Kartoteka.Instance;

            Pacjent pacjent = kartoteka.pacjenci.Where(x => x.Equals(imie, nazwisko)).FirstOrDefault();
            if(pacjent == null)
            {
                System.Console.WriteLine("Nie znaleziony: " + imie + " " + nazwisko);
                pacjent = new Pacjent(imie, nazwisko);
                kartoteka.pacjenci.Add(pacjent);
            }
            else
            {
                System.Console.WriteLine("Znaleziony: " + imie + " " + nazwisko);
            }

            System.Console.WriteLine("Obsluguje pacjenta: " + pacjent.ToString());


            Lekarz lekarz = ZwrocKolekcjeLekarzy(ZwrocELekarza(nazwalekarza)).FirstOrDefault();
            if(lekarz == null)
            {
                System.Console.WriteLine("Brak danego lekarza");
                return;
            }
            else
            {
                System.Console.WriteLine("Obsluguje lekarza: " + lekarz.ToString());
            }


            Wizyta wizyta = new Wizyta(pacjent, lekarz, DateTime.Now.AddDays(0));

            kartoteka.wizyty.Add(wizyta);
            System.Console.WriteLine("Przygotowana wizyta: " + wizyta.ToString());

            
        }

        private static IEnumerable<Lekarz> ZwrocKolekcjeLekarzy(ELekarz elekarz)
        {
            switch(elekarz)
            {
                case ELekarz.DERMATOLOG:
                    return Kartoteka.Instance.dermatolodzy;
                case ELekarz.KARDIOLOG:
                    return Kartoteka.Instance.kardiolodzy;
                case ELekarz.LARYNGOLOG:
                    return Kartoteka.Instance.laryngolodzy;
                case ELekarz.OKULISTA:
                    return Kartoteka.Instance.okulisci;
                case ELekarz.PULMUNOLOG:
                    return Kartoteka.Instance.pulmunolodzy;
                default:
                    return new List<Lekarz>();
            }
        }

        private static ELekarz ZwrocELekarza(string elekarzstring)
        {
            ELekarz elekarz;

            if (Enum.TryParse<ELekarz>(elekarzstring.ToUpper(), out elekarz) == false) //lepszy bo nie trzeba robic wyjatkow
            {
                return ELekarz.NONE;
            }

            return elekarz;
        }


    }


}
