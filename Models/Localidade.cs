using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IBGBlazor.Models
{
    public class Localidade
    {
        [Key]
        [Column(TypeName = "char(7)")]
        public string Id { get; set; }

        [Column(TypeName = "char(2)")]
        public string? State { get; set; }

        [Column(TypeName = "nvarchar(80)")]
        public string? City { get; set; }
    }
}
