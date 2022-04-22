using ConsoleAppRubrica.Core.Entities;
using ConsoleAppRubrica.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRubrica.Presentation.BusinessLayer
{
    public class BusinessLayer : IBusinessLayer
    {
        IRepoContatto blContatti;
        IRepoIndirizzo blIndirizzi;

        public BusinessLayer(IRepoContatto repoContatti, IRepoIndirizzo repoIndirizzi)
        {
            blContatti = repoContatti;
            blIndirizzi = repoIndirizzi;
        }
        public void AddAddress()
        {
            Indirizzo indirizzo = new Indirizzo();
            Console.WriteLine("inserisci Tipologia");
            indirizzo.Tipologia = Console.ReadLine();

            Console.WriteLine("inserisci Via");
            indirizzo.Via = Console.ReadLine();

            Console.WriteLine("inserisci Città");
            indirizzo.Citta = Console.ReadLine();

            Console.WriteLine("inserisci CAP");
            indirizzo.CAP = Console.ReadLine();

            Console.WriteLine("inserisci Provincia");
            indirizzo.Provincia = Console.ReadLine();

            Console.WriteLine("inserisci Nazione");
            indirizzo.Nazione = Console.ReadLine();

            GetAllContacts();
            Console.WriteLine("inserisci l'id utente a cui assegnare indirizzo");
            int id = LeggiNum();
            Contatto contatto = null;
            foreach (var c in blContatti.GetAll())
            {
                if (c.Id == id)
                {
                    contatto = c;
                }
            }

            if (contatto != null)
            {
                if (blIndirizzi.Add(indirizzo, contatto))
                {
                    Console.WriteLine("operazione riuscita");
                };
            }
            else
            {
                Console.WriteLine("l'id inserito non è corretto");
            }
        }

        public void AddContact()
        {
            Contatto c = new Contatto();

            Console.WriteLine("inserisci nome contatto");
            c.Nome = Console.ReadLine();
            Console.WriteLine("inserisci cognome");
            c.Cognome = Console.ReadLine();
            Console.WriteLine($"{(blContatti.Add(c) ? "operazione riuscita" : "qualcosa è andato storto :(")}");
        }

        public void GetAllContacts()
        {
            foreach (var c in blContatti.GetAll())
            {
                Console.WriteLine(c.ToString());
            }
        }

        public void RemoveContact()
        {
            GetAllContacts();
            Contatto contatto = null;
            Console.WriteLine("inserisci id contatto da eliminare: ");
            int id = LeggiNum();
            foreach (var c in blContatti.GetAll())
            {
                if (c.Id == id)
                {
                    contatto = c;
                }
            }

            if (contatto != null && blContatti.Delete(contatto))
            {
                Console.WriteLine("operazione riuscita");
            }
            else
            {
                Console.WriteLine("qualcosa è andato storto :(");
            }


        }

        public int LeggiNum()
        {
            int num = 0;

            while (!int.TryParse(Console.ReadLine(), out num) || num <= 0)
            {
                Console.WriteLine("numero errato");
            }

            return num;
        }

        public bool GetContactsWithAdress()
        {
            bool esiste = false;

            if (blContatti.GetAllWithAdress().Count > 0)
            {
                esiste = true;  
                foreach (var c in blContatti.GetAllWithAdress())
                {
                    Console.WriteLine("USER: ");
                    Console.WriteLine(c.ToString());
                    Console.WriteLine("INDIRIZZI: ");

                    foreach(var i in c.indirizzi)
                    {
                        Console.WriteLine(i.ToString());

                    }
                }

            }

            return esiste;
        }
    }
}
