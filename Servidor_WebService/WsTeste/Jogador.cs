using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WsTeste
{
    public class Jogador
    {

        private int valor;
        private int life;
        bool vez;

        public Jogador()
        {
            life = 8000;
        }


        public int Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public int Life
        {
            get { return life; }
        }

        public bool Vez
        {
            get { return vez; }
            set { vez = value; }
        }
    }
}