using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBCOREPROJETOLP.Models.Dominio
{
    public class Mochila
    {
        public int id { get; set; }
        public Jogador jogador { get; set; }
        public int jogadorID { get; set; }

        public ICollection<ItemMochila> itemMochilas { get; set; }
    }
}
