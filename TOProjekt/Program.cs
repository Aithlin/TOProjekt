using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOProjekt.Interfejs;

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
            catch(Exception)
            {
                System.Environment.Exit(1);
            }

            sprawdzDane();

            //Rejestracja.telefon("Dupencjusz", "Pierdzioch", "Pulmunolog");
            //Rejestracja.telefon("Dupencjusz", "Robak", "Kardiolog");
            //Rejestracja.telefon("Dupencjusz", "Robak", "Dermatolog");
            //Rejestracja.telefon("Dupencjusz", "Robak", "Okulista");
            //Rejestracja.telefon("Dupencjusz", "Robak", "Laryngolog");


            bool exit = false;
		    String napis;
	        while(exit == false)
	        {
	    	    Console.WriteLine("Wpisz komende (help zeby uzyskac pomoc x_x): "); 
	    	    try 
	    	    {
				    napis = Console.ReadLine();
                    IKomenda komenda = Parser.parsuj(napis);
                    exit = komenda.wykonaj();
			    } 
	    	    catch (Exception) 
	    	    {
				    Console.WriteLine("Error w czytaniu komendy");
			    }
	        }
        }

        static private void ustawDane()
        {
            //---------------------PACJENCI-----------------------
            Kartoteka.Instance.pacjenci.Add(new Pacjent("Dupencjusz", "Robak"));

            //---------------------LEKARZE------------------------
            Kartoteka.Instance.lekarze.Add(new Dermatolog("Alfred", "Zieba"));
            Kartoteka.Instance.lekarze.Add(new Kardiolog("Henryk", "Zajac"));
            Kartoteka.Instance.lekarze.Add(new Laryngolog("Rufus", "Mysior"));
            Kartoteka.Instance.lekarze.Add(new Okulista("Bohdan", "Fredzel"));
            Kartoteka.Instance.lekarze.Add(new Pulmunolog("Ronald", "Marek"));
        }

        static private void sprawdzDane()
        {
            //---------------------LEKARZE------------------------
            if (Kartoteka.Instance.dermatolodzy.Count() < 1)
            {
                System.Console.WriteLine("Nie został stworzony żaden dermatolog");
                throw new Exception();
            }
            if (Kartoteka.Instance.kardiolodzy.Count() < 1)
            {
                System.Console.WriteLine("Nie został stworzony żaden kardiolog");
                throw new Exception();
            }
            if (Kartoteka.Instance.laryngolodzy.Count() < 1)
            {
                System.Console.WriteLine("Nie został stworzony żaden laryngolog");
                throw new Exception();
            }
            if (Kartoteka.Instance.okulisci.Count() < 1)
            {
                System.Console.WriteLine("Nie został stworzony żaden okulista");
                throw new Exception();
            }
            if (Kartoteka.Instance.pulmunolodzy.Count() < 1)
            {
                System.Console.WriteLine("Nie został stworzony żaden pulmunolog");
                throw new Exception();
            }
                
        }
    }
}
