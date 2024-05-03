using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Cruds.Models
{
    [Table("tb_login")]
    public class Login
    {
        //Primary Key
        [Key]
        public int id { get; set; }

        //Defining fields
        [Required]
        public string Usuario { get; set; }

        [Required]
        public string Senha { get; set; }
    }
}
