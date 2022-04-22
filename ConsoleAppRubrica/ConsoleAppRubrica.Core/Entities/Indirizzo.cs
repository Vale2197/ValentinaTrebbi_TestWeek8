using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRubrica.Core.Entities
{
    public class Indirizzo
    {
        public int Id { get; set; }
        public string Tipologia { get; set; }
        public string Via { get; set; }
        public string Citta { get; set; }
        public string CAP { get; set; }
        public string Provincia { get; set; }
        public string Nazione { get; set; }

        public Indirizzo()
        {

        }
        public Indirizzo(int id,string tipologia, string via, string citta, string cap, string provincia, string nazione)
        {
            Id = id;
            Tipologia = tipologia;
            Via = via;
            Citta = citta;
            CAP = cap;
            Provincia = provincia;
            Nazione = nazione;
        }

        public override string ToString()
        {
            return $"ID: {Id} - Tipologia: {Tipologia} - Via: {Via} - Città: {Citta} - Cap: {CAP} - Provincia: {Provincia} - Nazione: {Nazione}";
        }
    }
}
