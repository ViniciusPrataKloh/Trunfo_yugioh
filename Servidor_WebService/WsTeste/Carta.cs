using System;
using System.Collections.Generic;
using System.Text;

namespace WsTeste
{
    
    public class Card
    {

        private int id;
        private int atk;
        private int def;

        public Card()
        {

        }

        public Card(int id, int atk, int def)
        {
            this.id = id;
            this.atk = atk;
            this.def = def;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Atk
        {
            get { return atk; }
            set { atk = value; }
        }

        public int Def
        {
            get { return def; }
            set { def = value; }
        }

        public virtual void desenhar()
        {
            //"Img/" + nome + ".jpg";
        }

    }
}