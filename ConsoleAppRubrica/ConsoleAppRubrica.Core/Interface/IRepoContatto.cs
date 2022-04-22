using ConsoleAppRubrica.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRubrica.Core.Interface
{
    public interface IRepoContatto
    {
        bool Delete(Contatto contatto);
        List<Contatto> GetAll();
        bool Add(Contatto contatto);

        List<Contatto> GetAllWithAdress();
    }
}
