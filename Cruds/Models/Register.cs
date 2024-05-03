using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Cruds.Models
{
    [Table("tb_register")]
    public class Register
    {
        //Primary Key
        [Key]
        public int Id { get; set; }

        //Defining fields
        [Required]
        public string Usuario { get; set; }

        [Required]
        public string Senha { get; set; }

        [Required]
        public string Confirme_a_Senha { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Confirme_o_Email { get; set; }

    }
}
