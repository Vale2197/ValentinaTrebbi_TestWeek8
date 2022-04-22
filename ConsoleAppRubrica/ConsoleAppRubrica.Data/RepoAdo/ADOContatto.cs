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
    public class ADOContatto : IRepoContatto
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RubricaDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public bool Add(Contatto contatto)
        {
            bool done = false;
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            SqlCommand cmd = new SqlCommand("insert into contatto values( @nome , @cognome , null )", sqlConn);
            cmd.Parameters.AddWithValue("@nome", contatto.Nome);
            cmd.Parameters.AddWithValue("@cognome", contatto.Cognome);
            if (cmd.ExecuteNonQuery() > 0)
            {
                done = true;
            };
            sqlConn.Close();
            return done;
        }

        public bool Delete(Contatto contatto)
        {
            bool done = false;

            if (contatto.indirizzi.Count == 0)
            {

                SqlConnection sqlConn = new SqlConnection(connectionString);
                sqlConn.Open();
                SqlCommand cmd = new SqlCommand("delete from contatto where id = @idCont", sqlConn);
                cmd.Parameters.AddWithValue("@idCont", contatto.Id);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    done = true;
                };
                sqlConn.Close();
            }
            return done;
        }

        public List<Contatto> GetAll()
        {
            List<Contatto> contatti = new List<Contatto>();
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            SqlCommand cmd = new SqlCommand("select * from contatto", sqlConn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = (int)reader[0];
                string nome = (string)reader[1];
                string cognome = (string)reader[2];

                Contatto contatto = new Contatto(id, nome, cognome);
                contatti.Add(contatto);
            }
            sqlConn.Close();

            return contatti;
        }

        public List<Contatto> GetAllWithAdress()
        {

            List<Contatto> contatti = new List<Contatto>();
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            SqlCommand cmd = new SqlCommand("select contatto.*, indirizzo.* from contatto join indirizzo on Contatto.idIndirizzo = Indirizzo.id", sqlConn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = (int)reader[0];
                string nome = (string)reader[1];
                string cognome = (string)reader[2];

                int idIndirizzo = (int)reader[4];
                string tipologia = (string)reader[5];
                string via = (string)reader[6];
                string citta = (string)reader[7];
                string cap = (string)reader[8];
                string provincia = (string)reader[9];
                string nazione = (string)reader[10];

                Indirizzo indirizzo = new Indirizzo(idIndirizzo, tipologia, via, citta, cap, provincia, nazione);

                Contatto contatto = new Contatto(id, nome, cognome);

                contatto.indirizzi.Add(indirizzo);

                if (!contatti.Contains(contatto))
                {
                    contatti.Add(contatto);
                };
            }
            sqlConn.Close();

            return contatti;
        }
    }
}
