using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WEBCOREPROJETOLP.Models.Dominio
{
    [Table("Jogador")]
    public class Jogador
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("ID")]
        public int id { get; set; }

        [StringLength(50, ErrorMessage = "O nome do jogador deve ser inferior a 50 caracteres.", MinimumLength = 5)]
        [Required(ErrorMessage = "O nome do Jogador deve ser preenchido.")]
        [DisplayName("Nome")]
        public string nome { get; set; }

        [StringLength(50, ErrorMessage = "A cidade do jogador deve ser inferior a 50 caracteres.", MinimumLength = 5)]
        [Required(ErrorMessage = "A cidade do Jogador deve ser preenchida.")]
        [DisplayName("Nome")]
        public string cidade { get; set; }

        [StringLength(50, ErrorMessage = "O estado do jogador deve ser inferior a 50 caracteres.", MinimumLength = 5)]
        [Required(ErrorMessage = "O estado do Jogador deve ser preenchido.")]
        [DisplayName("Nome")]
        public string estado { get; set; }

        [DisplayName("Pokémon Inicial")]
        [Required(ErrorMessage = "O Pokémon deve ser selecionado")]
        public Pokemon inicial { get; set; }

        [DisplayName("Pokébola")]
        [Required(ErrorMessage = "A pokébola deve ser selecionada")]
        public Pokebola pokebola { get; set; }

        [Required(ErrorMessage = "Informar a quantidade de Pokébolas")]
        [DisplayName("Quantidade Pokébola")]
        public int quantidadePokebola { get; set; }
    }
}
