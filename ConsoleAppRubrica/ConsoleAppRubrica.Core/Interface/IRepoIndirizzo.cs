using ConsoleAppRubrica.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRubrica.Core.Interface
{
    public interface IRepoIndirizzo
    {
        bool Add(Indirizzo indirizzo, Contatto contatto);
        List<Indirizzo> GetAll();

    }
}
