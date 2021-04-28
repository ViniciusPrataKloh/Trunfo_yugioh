using System;
using System.Collections;
using System.Text;
//using System.Data.SqlClient;
using MySql.Data;
using System.Data;
using System.Collections.Generic;
using System.Collections;
using MySql.Data.MySqlClient;

namespace WsTeste
{

    class Deck
    {

        

        List<Card> listaCartas = new List<Card>();
        Stack<Card> deck = new Stack<Card>();
        int cont;

        public void imprimirLista(List<int> lista) { 
        
            foreach(int i in lista)
            {
                Console.Write(i + " - ");
            }
        
        }

        private void imprimirCartas() {
            Console.WriteLine("deck " + deck.Count);

            
            while(deck.Count>0) {
               
                Console.WriteLine( "Card" + ((Card)deck.Pop()).Id );
            }
        
        }




        public Stack<Card> embaralharCartas()
        {
            int k = 0;
            Random r = new Random();
            List<int> listaNum = new List<int>();
            int n = listaCartas.Count;
            Console.WriteLine("numero cartas" + listaCartas.Count);
            
                
                n--;

                do
                {
                    k = r.Next(n + 1);                   
                    

                    if (!listaNum.Contains(k)){                        
                       
                        listaNum.Add(k);
                    }

                    

                } while (listaNum.Count <= n);

                imprimirLista(listaNum);                
            
            Console.WriteLine("lista num " + listaNum.Count);

                //foreach(int i in listaNum)
            for (int i = 0; i < listaNum.Count;i++ )
                deck.Push(listaCartas[listaNum[i]]);


            Console.WriteLine("lista cartas " + listaCartas.Count);
            Console.WriteLine("deck " + deck.Count);

            return deck;
                
            

        }



        /*public void embaralharCartas()
        {
            int k = 0;
            Random r = new Random();
            List<int> listaNum = new List<int>();
            int n = listaCartas.Count;

            do{
            
                bool permiteAdd = true;
                n--;

                do
                {
                    k = r.Next(n + 1);
                    Console.WriteLine("K -" +  k);
                    if (listaNum.Contains(k))
                        permiteAdd = false;
                    else
                        permiteAdd = true;
                } while (!permiteAdd);

                permiteAdd = true;

                listaNum.Add(k);
                Card aux = listaCartas[k];
                deck.Push(aux);
                Card cardAux = (Card)deck.Pop();
                //MessageBox.Show("ID: " + cardAux.Id.ToString() + "ATQ: " + cardAux.Atk.ToString() + "DEF: " + cardAux.Def.ToString());
                Console.WriteLine(cardAux.Id.ToString());
                Console.WriteLine("N- " +n);
                
            }while (n> 1);

        }*/





        public void montarDeck()
        {

            // ConexÃ£o BD para resgatar id carta.

            //String de conexÃ£o:
            string strConnection = @"server=localhost; ";
            strConnection += "user id=root; password=downhill1234; database=final_pav";

            //Objeto que faz a conexÃ£o com o Banco de Dados:
            MySqlConnection connection = new MySqlConnection(strConnection);

            // Consulta:
            try
            {
                string query = "SELECT * FROM  card";

                //Criando object command:
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;

                //Abre conexÃ£o:
                connection.Open();

                //Cria um objeto:
                MySqlDataReader dr = cmd.ExecuteReader();


                while (dr.Read())
                {

                    Card card = new Card();
                    card.Id = Convert.ToInt32(dr["id"]);
                    card.Atk = Convert.ToInt32(dr["atk"]);
                    card.Def = Convert.ToInt32(dr["def"]);
                    //card.Atk = Convert.ToInt32(dr["atk_especial"]);

                    listaCartas.Add(card);
                }

            }
            catch (MySqlException ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
    }
}