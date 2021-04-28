using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace WsTeste
{
    public class Banco
    {
        public void insereCartaVez(Card cartaVez, int id)
        {

            // ConexÃ£o BD para resgatar id carta.

            //String de conexÃ£o:
            string strC = @"server=localhost; user id=root; password=downhill1234; database=final_pav";

            //Objeto que faz a conexÃ£o com o Banco de Dados:
            MySqlConnection connection = new MySqlConnection(strC);

            // Consulta:
            try
            {
                string query = "INSERT INTO cardVez(id, atk, def, idCliente)";
                query += "VALUES (@id, @atk, @def, @idCliente)";

                //Criando object command:
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;

                //Registrar parâmetros:
                cmd.Parameters.AddWithValue("@id", cartaVez.Id);
                cmd.Parameters.AddWithValue("@atk", cartaVez.Atk);
                cmd.Parameters.AddWithValue("@def", cartaVez.Def);
                cmd.Parameters.AddWithValue("@idCliente", id);

                //Abre conexÃ£o:
                connection.Open();

                //Cria um objeto:
                MySqlDataReader dr = cmd.ExecuteReader();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

// -------------------------------------------------------------------------------------------------

        public Card buscarCartaOponente(int idC)
        {

            //String de conexÃ£o:
            string strC = @"server=localhost; user id=root; password=downhill1234; database=final_pav";

            //Objeto que faz a conexÃ£o com o Banco de Dados:
            MySqlConnection connection = new MySqlConnection(strC);

            // Consulta:
            try
            {
                string query = "SELECT * FROM cardVez WHERE idCliente = @idC;";

                //Criando object command:
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;

                //Registrar parâmetros:
                cmd.Parameters.AddWithValue("@idC", idC);

                connection.Open();

                //Cria um objeto:
                MySqlDataReader dr2 = cmd.ExecuteReader();

                Card cartaVezOponente = new Card();

                while (dr2.Read())
                {
                    cartaVezOponente.Id = Convert.ToInt32(dr2["id"]);
                    cartaVezOponente.Atk = Convert.ToInt32(dr2["atk"]);
                    cartaVezOponente.Def = Convert.ToInt32(dr2["def"]);
                }

                return cartaVezOponente;

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

// ------------------------------------------------------------------------------------------------

        public void apagarCartaOponente(int id)
        {
            // ConexÃ£o BD para resgatar id carta.

            //String de conexÃ£o:
            string strC = @"server=localhost; user id=root; password=downhill1234; database=final_pav";

            //Objeto que faz a conexÃ£o com o Banco de Dados:
            MySqlConnection connection = new MySqlConnection(strC);

            // Consulta:
            try
            {
                string query = "DELETE FROM cardVez WHERE idCliente = @id;";

                //Criando object command:
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;

                //Registrar parâmetros:
                cmd.Parameters.AddWithValue("@id", id);

                connection.Open();

                //Cria um objeto:
                MySqlDataReader dr2 = cmd.ExecuteReader();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}