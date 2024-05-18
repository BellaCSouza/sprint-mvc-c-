using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCProject.Models
{
    [Table("tb_usuario")]
    public class Usuario
    {
        [Display(Name = "Código")]
        [Column("id_usuario")]
        public int ID { get; set; }

        [Display(Name = "Email")]
        [Column("email_usuario")]
        public string Email { get; set; }

        [Display(Name = "Senha")]
        [Column("senha_usuario")]
        public string Senha { get; set; }
    }


}
