using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WEBCOREPROJETOLP.Models.Dominio
{
    [Table("Pokebola")]
    public class Pokebola
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("ID")]
        public int id { get; set; }

        [StringLength(20, ErrorMessage = "O tamanho do campo Nome está incorreto.", MinimumLength = 5)]
        [Required(ErrorMessage = "O campo Nome deve ser preenchido.")]
        [DisplayName("Nome")]
        public string nome { get; set; }

        [StringLength(20, ErrorMessage = "O tamanho do campo Cor está incorreto.", MinimumLength = 5)]
        [Required(ErrorMessage = "O campo Cor deve ser preenchido.")]
        [DisplayName("Cor")]
        public string cor { get; set; }
    }
}
