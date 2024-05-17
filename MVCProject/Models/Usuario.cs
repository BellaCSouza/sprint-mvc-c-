using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCProject.Models
{
    [Table("TB_USUARIO")]
    public class Usuario
    {
        [Display(Name = "Código")]
        public int Id { get; set; }
        public string Nome { get; set; }
    }

    
}
