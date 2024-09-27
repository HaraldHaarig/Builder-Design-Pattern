using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    internal class Haus
    {
        public int Stockwerke { get; set; }
        public int Fensteranzahl { get; set; }
        public string Dachtyp { get; set; }
        public int Zimmeranzahl { get; set; }

        public override string ToString()
        {
            return $"Haus mit {Stockwerke} Stockwerken, {Fensteranzahl} Fenstern, {Zimmeranzahl} Zimmern und einem {Dachtyp}-Dach.";
        }

    }
}
