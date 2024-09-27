using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    internal class Director
    {
        private HausBuilder _hausbuilder;
        public Director(HausBuilder builder)
        {
            _hausbuilder = builder;
        }

        public void BuildFamilienhaus()
        {
            _hausbuilder
            .AddStockwerke(2)
            .AddFenster(10)
            .AddZimmeranzahl(5)
            .AddDachtyp("Satteldach");
        }

        public void BuildVilla()
        {
            _hausbuilder
            .AddStockwerke(3)
            .AddFenster(20)
            .AddZimmeranzahl(10)
            .AddDachtyp("Flachdach");
        }

        public Haus GetHaus()
        {
            return _hausbuilder.Build();
        }
    }
}
