using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WEBCOREPROJETOLP.Models.Dominio
{

    public class Jogador
    {
        public int id { get; set; }
        public Usuario usuario { get; set; }
        public int usuarioID { get; set; }
        public Mochila mochila { get; set; }
        public string nome { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string pais { get; set; }

    }
}
