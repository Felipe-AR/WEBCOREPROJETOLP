using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WEBCOREPROJETOLP.Models.Dominio
{
    [Table("Usuarios")]
    public class Usuarios
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("ID")]
        public int id { get; set; }
        
        [DisplayName("E-mail")]
        [StringLength(50, ErrorMessage = "O tamanho do e-mail é superior a 50 caracteres.")]
        [Required(ErrorMessage = "O campo e-mail deve ser preenchido.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail inválido.")]
        public string email { get; set; }

        [DisplayName("Usuario")]
        [StringLength(50, ErrorMessage = "O nome do usuário é superior a 50 caracteres.")]
        [Required(ErrorMessage = "O campo usuário deve ser preenchido.")]
        public string usuario { get; set; }

        [DisplayName("Senha")]
        [StringLength(256)]             
        [Required(ErrorMessage = "O campo senha deve ser preenchido.")]
        [DataType(DataType.Password)]
        public string senha { get; set; }
    }
}
