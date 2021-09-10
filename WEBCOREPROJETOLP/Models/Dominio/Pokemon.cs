using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WEBCOREPROJETOLP.Models.Dominio
{
    [Table("Pokemon")]
    public class Pokemon
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("ID")]
        public int id { get; set; }

        [StringLength(35, ErrorMessage = "O tamanho do campo do Nome do Pokémon está incorreto.", MinimumLength = 4)]
        [Required(ErrorMessage = "O campo Nome deve ser preenchido.")]
        [DisplayName("Nome")]
        public string nome { get; set; }

        [DisplayName("Tipo do Pokémon")]
        [Required(ErrorMessage = "O Tipo do Pokémon deve ser selecionado.")]
        public PokemonTipo tipo { get; set; }
    }
}
