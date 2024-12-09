using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pizzeria.DAL.Models
{
    public class Adresse
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Rue { get; set; } = null!;

        [MaxLength(10)]
        public string Numero { get; set; } = null!;

        [Column(TypeName = "CHAR(4)")]
        public string CodePostal { get; set; } = null!;

        [MaxLength(100)]
        public string Ville { get; set; } = null!;
        public int ClientId { get; set; }

        [ForeignKey(nameof(ClientId))]
        public Client Client { get; set; } = null!;
    }
}
