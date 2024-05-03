using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Cruds.Models
{
    [Table("tb_assessment")]
    public class Assessment
    {
        //Primary Key
        [Key]
        public int Id { get; set; }

        //Defining fields
        public int Nota { get; set; }

        public string Comentário { get; set; }
    }
}
