using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRubrica.Presentation.BusinessLayer
{
    internal interface IBusinessLayer
    {
        void GetAllContacts();
        void AddContact();
        void AddAddress();
        void RemoveContact();
    }
}
