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
            ustawDane();
            try
            {
                sprawdzDane();
            }
            catch(Exception e)
            {
                System.Environment.Exit(1);
            }

            sprawdzDane();

            Rejestracja.telefon("Dupencjusz", "Pierdzioch", "Pulmunolog");
            Rejestracja.telefon("Dupencjusz", "Robak", "Kardiolog");
        }

        static private void ustawDane()
        {
            //---------------------PACJENCI-----------------------
            Kartoteka.getInstance().pacjenci.Add(new Pacjent("Dupencjusz", "Robak"));

            //---------------------LEKARZE------------------------
            Kartoteka.getInstance().pulmunolodzy.Add(new Pulmunolog("Ronald", "Marek"));
        }

        static private void sprawdzDane()
        {
            //---------------------LEKARZE------------------------
            if (Kartoteka.getInstance().dermatolodzy.Count() < 1)
            {
                System.Console.WriteLine("Nie został stworzony żaden dermatolog");
                throw new Exception();
            }
            if (Kartoteka.getInstance().kardiolodzy.Count() < 1)
            {
                System.Console.WriteLine("Nie został stworzony żaden kardiolog");
                throw new Exception();
            }
            if (Kartoteka.getInstance().laryngolodzy.Count() < 1)
            {
                System.Console.WriteLine("Nie został stworzony żaden laryngolog");
                throw new Exception();
            }
            if (Kartoteka.getInstance().okulisci.Count() < 1)
            {
                System.Console.WriteLine("Nie został stworzony żaden okulista");
                throw new Exception();
            }
            if (Kartoteka.getInstance().pulmunolodzy.Count() < 1)
            {
                System.Console.WriteLine("Nie został stworzony żaden pulmunolog");
                throw new Exception();
            }
                
        }
    }
}
