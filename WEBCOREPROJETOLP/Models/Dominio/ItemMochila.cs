using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBCOREPROJETOLP.Models.Dominio
{
    public class ItemMochila
    {
        public int id { get; set; }
        public Mochila mochila { get; set; }
        public int mochilaID { get; set; }
        public Pokemon pokemon { get; set; }
        public int pokemonID { get; set; }

    }
}
