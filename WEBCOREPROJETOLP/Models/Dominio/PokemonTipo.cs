using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WEBCOREPROJETOLP.Models.Dominio
{
    [Table("Pokemon_Tipo")]
    public class PokemonTipo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("ID")]
        public int id { get; set; }

        [StringLength(30, ErrorMessage = "O tamanho do campo de Descrição do Pokémon está incorreto.", MinimumLength = 4)]
        [Required(ErrorMessage = "O campo Descrição deve ser preenchido.")]
        [DisplayName("Descrição")]
        public string descricao { get; set; }
    }
}
