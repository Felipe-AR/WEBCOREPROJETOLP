﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WEBCOREPROJETOLP.Models.Dominio
{
    public class PokemonTipo
    {
        public int id { get; set; }
        public string descricao { get; set; }

        public ICollection<Pokemon> pokemons { get; set; }
    }
}
