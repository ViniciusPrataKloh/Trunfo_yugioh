using System;
using System.Collections;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using MySql.Data.MySqlClient;

namespace WsTeste
{
    /// <summary>
    /// Summary description for WsOperacoes
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WsOperacoes : System.Web.Services.WebService
    {
        private Card cartaVez1;
        private Card cartaVez2;
        private int life1;
        private int life2;
        private int id;
        private int diferenca;
        Banco banco = new Banco();


        [WebMethod]
        public Card getCardOponente(int id)
        { 
            Card cartaVez = new Card();
            if (id == 1)
            {
                cartaVez = banco.buscarCartaOponente(2);
                banco.apagarCartaOponente(2);
            } 
            else if(id == 2)
            {
                cartaVez = banco.buscarCartaOponente(1);
                banco.apagarCartaOponente(1);
            }
            return cartaVez;
        }


        [WebMethod]
        public Card[] getStack()
        {
            Stack<Card> pilha;
            Deck d = new Deck();
            d.montarDeck();

            pilha = d.embaralharCartas();

            return pilha.ToArray();
        }


        [WebMethod]
        public void enviaCarta(Card carta, int id)
        {
            banco.insereCartaVez(carta, id);
        }

    }
}
