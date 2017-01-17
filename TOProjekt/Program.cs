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
            Kartoteka.getInstance().lekarze.Add(new Dermatolog("Alfred", "Zieba"));
            Kartoteka.getInstance().lekarze.Add(new Kardiolog("Henryk", "Zajac"));
            Kartoteka.getInstance().lekarze.Add(new Laryngolog("Rufus", "Mysior"));
            Kartoteka.getInstance().lekarze.Add(new Okulista("Bohdan", "Fredzel"));
            Kartoteka.getInstance().lekarze.Add(new Pulmunolog("Ronald", "Marek"));
        }

        static private void sprawdzDane()
        {
            //---------------------LEKARZE------------------------
            if (Kartoteka.getInstance().lekarze.Where(x => x.GetType().Equals(typeof(Dermatolog))).Count() < 1)
            {
                System.Console.WriteLine("Nie został stworzony żaden dermatolog");
                throw new Exception();
            }
            if (Kartoteka.getInstance().lekarze.Where(x => x.GetType().Equals(typeof(Kardiolog))).Count() < 1)
            {
                System.Console.WriteLine("Nie został stworzony żaden kardiolog");
                throw new Exception();
            }
            if (Kartoteka.getInstance().lekarze.Where(x => x.GetType().Equals(typeof(Laryngolog))).Count() < 1)
            {
                System.Console.WriteLine("Nie został stworzony żaden laryngolog");
                throw new Exception();
            }
            if (Kartoteka.getInstance().lekarze.Where(x => x.GetType().Equals(typeof(Okulista))).Count() < 1)
            {
                System.Console.WriteLine("Nie został stworzony żaden okulista");
                throw new Exception();
            }
            if (Kartoteka.getInstance().lekarze.Where(x => x.GetType().Equals(typeof(Pulmunolog))).Count() < 1)
            {
                System.Console.WriteLine("Nie został stworzony żaden pulmunolog");
                throw new Exception();
            }
                
        }
    }
}
