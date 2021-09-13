using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WEBCOREPROJETOLP.Models.Dominio
{
    public class Usuario
    {
        public int id { get; set; }
        public Jogador jogador { get; set; }
        public int jogadorID { get; set; }
        public string email { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }

    }
}
