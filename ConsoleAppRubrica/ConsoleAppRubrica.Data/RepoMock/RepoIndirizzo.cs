using ConsoleAppRubrica.Core.Entities;
using ConsoleAppRubrica.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRubrica.Data.RepoMock
{
    public class RepoIndirizzo : IRepoIndirizzo
    {
        private List<Indirizzo> indirizzi = new List<Indirizzo>()
        {
            new Indirizzo(1, "Residenza", "Bruscoli", "Torino", "61111", "Torino", "italia"),
            new Indirizzo(2, "Domicilio", "KKK 45", "Firenze", "61213", "Firi", "italia"),
        };

        public bool Add(Indirizzo indirizzo, Contatto contatto)
        {
            bool done = true;


            List<int> ids = new List<int>();
            foreach (Indirizzo i in indirizzi)
            {
                ids.Add(i.Id);
            }

            indirizzo.Id = ids.Max()+1;

            foreach (var i in contatto.indirizzi)
            {
                if (i.Id == indirizzo.Id)
                {
                    done = false;
                }
            }

            if (done)
            {
                indirizzi.Add(indirizzo);
                contatto.indirizzi.Add(indirizzo);
            }

            return done;
        }

        public List<Indirizzo> GetAll()
        {
            return indirizzi;
        }

    }
}
