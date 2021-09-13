using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WEBCOREPROJETOLP.Models.Dominio
{
    public class Pokemon
    {
        public int id { get; set; }
        public string nome { get; set; }
        public PokemonTipo tipo { get; set; }
        public int tipoID { get; set; }

        public ICollection<ItemMochila> itemMochilas { get; set; }
    }
}
