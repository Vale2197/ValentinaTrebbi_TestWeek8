using ConsoleAppRubrica.Core.Entities;
using ConsoleAppRubrica.Core.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRubrica.Data.RepoAdo
{
    public class ADOIndirizzo : IRepoIndirizzo
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RubricaDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public bool Add(Indirizzo indirizzo, Contatto contatto)
        {
            bool done = false;

            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            SqlCommand cmd = new SqlCommand("insert into indirizzo values( @tipologia , @via , @citta , @cap , @prov , @nazione  )", sqlConn);
            cmd.Parameters.AddWithValue("@tipologia", indirizzo.Tipologia);
            cmd.Parameters.AddWithValue("@via", indirizzo.Via);
            cmd.Parameters.AddWithValue("@citta", indirizzo.Citta);
            cmd.Parameters.AddWithValue("@cap", indirizzo.CAP);
            cmd.Parameters.AddWithValue("@prov", indirizzo.Provincia);
            cmd.Parameters.AddWithValue("@nazione", indirizzo.Nazione);
            if (cmd.ExecuteNonQuery() > 0)
            {
                done = true;
            };
            sqlConn.Close();

            List<int> ids = new List<int>(); 

            if(GetAll().Count > 0)
            {
                foreach (var i in GetAll())
                {
                    ids.Add(i.Id);
                }
            }

            int idUltimoIndirizzoAggiunto = ids.Max();
            indirizzo.Id = idUltimoIndirizzoAggiunto;

            if (done)
            {

                sqlConn.Open();
                SqlCommand assegna = new SqlCommand(" update contatto set idIndirizzo = @idInd where Contatto.Id = @idCont ; ", sqlConn);
                assegna.Parameters.AddWithValue("@idInd", indirizzo.Id);
                assegna.Parameters.AddWithValue("@idCont", contatto.Id);
                assegna.ExecuteNonQuery();
                sqlConn.Close();
            }

            return done;
        }

        public List<Indirizzo> GetAll()
        {
            List<Indirizzo> indirizzi = new List<Indirizzo>();
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            SqlCommand cmd = new SqlCommand("select * from indirizzo", sqlConn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = (int)reader[0];
                string tipologia = (string)reader[1];
                string via = (string)reader[2];
                string citta = (string)reader[3];
                string cap = (string)reader[4];
                string provincia = (string)reader[5];
                string nazione = (string)reader[6];

                Indirizzo indirizzo = new Indirizzo(id, tipologia, via, citta, cap, provincia, nazione);
                indirizzi.Add(indirizzo);
            }
            sqlConn.Close();

            return indirizzi;
        }
    }
}
