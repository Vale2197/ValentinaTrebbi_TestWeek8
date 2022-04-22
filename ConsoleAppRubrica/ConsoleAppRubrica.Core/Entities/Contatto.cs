using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRubrica.Core.Entities
{
    public class Contatto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }

        public List<Indirizzo> indirizzi = new List<Indirizzo>();
        public Contatto()
        {

        }

        public Contatto(int id,string nome, string cognome)
        {
            Id = id;
            Nome = nome;
            Cognome = cognome;
        }

        public override string ToString()
        {
            return $"ID: {Id} - Nome: {Nome} - Cognome: {Cognome}";
        }
    }
}
