﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TOProjekt
{
    class Rejestracja
    {
        public static void telefon(string imie, string nazwisko,string nazwalekarza)
        {
            Pacjent pacjent = Kartoteka.getInstance().pacjenci.Where(x => x.Equals(imie, nazwisko)).FirstOrDefault();
       
            if (pacjent == null)
            {
                System.Console.WriteLine("Nie znaleziony: " + imie + " " + nazwisko);
                pacjent = new Pacjent(imie, nazwisko);
                Kartoteka.getInstance().pacjenci.Add(pacjent);
            }
            else
            {
                System.Console.WriteLine("Znaleziony: " + imie + " " + nazwisko);
            }

            System.Console.WriteLine("Obsluguje pacjenta: " + pacjent.ToString());

            //
           // Lekarz lekarz = Kartoteka.getInstance().lekarze.Where(x => x.GetType().Equals(Type.GetType(nazwalekarza))).Where(x => x.Equals(imie, nazwisko)).FirstOrDefault();
            Lekarz lekarz = Kartoteka.getInstance().lekarze.Where(x => x.GetType().Equals(Type.GetType(nazwalekarza))).FirstOrDefault();
            if (lekarz == null)
            {
                System.Console.WriteLine("Brak danego lekarza");
                //throw new NotImplementedException();
            }
            else
            {
                System.Console.WriteLine("Obsluguje lekarza: " + lekarz.ToString());
            }
           // DateTime godzina = new DateTime().AddDays(1).AddHours(1);
            //Wizyta wizyta = new Wizyta(pacjent,lekarz,godzina);
          

        }
        public static Wizyta zarejestruj(Pacjent pacjent,Lekarz lekarz, DateTime godzina)
        {
            Wizyta wizyta1 = new Wizyta(pacjent, lekarz, godzina);
            return wizyta1;
        }

        //private static HashSet<Lekarz> ZwrocKolekcjeLekarzy(ELekarz elekarz)
        //{
        //    switch(elekarz)
        //    {
        //        case ELekarz.DERMATOLOG:
        //            return Kartoteka.getInstance().dermatolodzy;
        //        case ELekarz.KARDIOLOG:
        //            return Kartoteka.getInstance().kardiolodzy;
        //        case ELekarz.LARYNGOLOG:
        //            return Kartoteka.getInstance().laryngolodzy;
        //        case ELekarz.OKULISTA:
        //            return Kartoteka.getInstance().okulisci;
        //        case ELekarz.PULMUNOLOG:
        //            return Kartoteka.getInstance().pulmunolodzy;
        //        default:
        //            throw new NotImplementedException();
        //    }
        //}

        //private static ELekarz ZwrocELekarza(string elekarzstring)
        //{
        //    try
        //    {
        //        return (ELekarz)Enum.Parse(typeof(ELekarz), elekarzstring, true);
        //    }
        //    catch (ArgumentException)
        //    {
        //        //return ELekarz.PIERWSZYKONTAKT;
        //        throw new NotImplementedException();
        //    }
        //}


    }


}
