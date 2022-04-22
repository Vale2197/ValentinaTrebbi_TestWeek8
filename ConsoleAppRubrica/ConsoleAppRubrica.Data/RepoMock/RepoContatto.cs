using ConsoleAppRubrica.Core.Entities;
using ConsoleAppRubrica.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRubrica.Data.RepoMock
{
    public class RepoContatto : IRepoContatto
    {
        private List<Contatto> contatti = new List<Contatto>()
        {
            new Contatto(1,"Vale", "Trebbi"),
            new Contatto(2,"Jim", "Alpert"),
            new Contatto(3,"Pam", "Bisely"),
        };
        public bool Add(Contatto contatto)
        {


            List<int> ids = new List<int>();

            foreach (Contatto i in contatti)
            {
                ids.Add(i.Id);
            }
            contatto.Id = ids.Max() + 1;

            contatti.Add(contatto);
            return true;
        }

        public bool Delete(Contatto contatto)
        {
            bool done = false;

            if (contatto.indirizzi.Count == 0)
            {

                contatti.Remove(contatto);
                done = true;
            }
            return true;
        }

        public List<Contatto> GetAll()
        {
            return contatti;
        }

        public List<Contatto> GetAllWithAdress()
        {
            List<Contatto> contConIndirizzo = new List<Contatto>();

            foreach (var i in GetAll())
            {
                if (i.indirizzi.Count > 0)
                {
                    contConIndirizzo.Add(i);
                }
            }

            return contConIndirizzo;
        }
    }
}
