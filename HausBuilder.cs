using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    internal class HausBuilder
    {

        public HausBuilder()
        {
        }

        /*       public void setStockwerke(int stockwerke) { 
                   _stockwerke = stockwerke;
               }

               public void setFenster(int fensteranzahl)
               {
                   _fensteranzahl = fensteranzahl;
               }

               public void setZimmeranzahl (int zimmeranzahl)
               {
                   _zimmeranzahl= zimmeranzahl;
               }

               public void setDachtyp(string dachtyp)
               {
                   _dachtyp = dachtyp;
               }*/

        private Haus _haus = new Haus();

        public HausBuilder AddStockwerke(int stockwerke)
        {
            _haus.Stockwerke = stockwerke;
            return this;
        }

        public HausBuilder AddFenster(int fensteranzahl)
        {
            _haus.Fensteranzahl = fensteranzahl;
            return this;
        }

        public HausBuilder AddZimmeranzahl(int zimmeranzahl)
        {
            _haus.Zimmeranzahl = zimmeranzahl;
            return this;
        }

        public HausBuilder AddDachtyp(string dachtyp)
        {
            _haus.Dachtyp = dachtyp;
            return this;
        }

        public Haus Build()
        {
            return _haus;
        }
    }
}
