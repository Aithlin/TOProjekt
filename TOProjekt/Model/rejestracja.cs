using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOProjekt
{
    class Rejestracja
    {
        public static void telefon(string imie, string nazwisko, string nazwalekarza)
        {
            Kartoteka kartoteka = Kartoteka.Instance;

            Pacjent pacjent = kartoteka.pacjenci.Where(x => x.Equals(imie, nazwisko)).FirstOrDefault();
            if (pacjent == null)
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
            if (lekarz == null)
            {
                System.Console.WriteLine("Brak danego lekarza");
                return;
            }
            else
            {
                System.Console.WriteLine("Obsluguje lekarza: " + lekarz.ToString());
            }

            // Wizyta wizyta = new Wizyta(pacjent, lekarz, DateTime.Now.AddDays(0));

            // deleguje tworzenie obiektu Wizyta do WizytaBuilder
            WizytaBuilder wb = new WizytaBuilder();

            //KAZDY LEKARZ PRZYJMUJE W GODZINACH OD 8 DO 13 
            //czas przeznaczony na wizyte to godzina więc 5 wizyt/dzien
            DateTime termWiz;
            Wizyta wiz = kartoteka.wizyty.Where(x => x.lekarz == lekarz).LastOrDefault();
            if (wiz == null)
                termWiz = DateTime.Today.AddDays(1).AddHours(8);
            else
            {
                if (wiz.godzina < DateTime.Today.AddDays(1))//sprawdzam czy ostatnia wizyta u lekarza jest o godzinie 12 (pacjent zostanie zapisany na kolejny wolny termin nastepnego dnia)
                    termWiz = DateTime.Today.AddDays(1).AddHours(8);
                else if (wiz.godzina.Hour == 12)
                    termWiz = wiz.godzina.AddDays(1).Date.AddHours(8);//wyciagam date i dodaje 8 godzin od poczatku dnia
                else
                    termWiz = wiz.godzina.AddHours(1);
            }
                
            // wywoluje po kolei metody z Builder, przygotowujac obiekt wizyta. Na koncu za pomoca build zwracam sama wizyte
            // dzieki temu ze metody WizytaBuilder zwracaja wb (return this), moge wszystko zrobic w jednym ciagu wywolan
             Wizyta wizyta2 = wb.
                SetPacjent(pacjent).
                SetLekarz(lekarz).
                SetGodzina(termWiz).
                Build;

            kartoteka.wizyty.Add(wizyta2);
            System.Console.WriteLine("Przygotowana wizyta: " + wizyta2.ToString());


        }

        private static IEnumerable<Lekarz> ZwrocKolekcjeLekarzy(ELekarz elekarz)
        {
            switch (elekarz)
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
