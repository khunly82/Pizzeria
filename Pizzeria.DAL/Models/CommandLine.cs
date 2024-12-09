using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pizzeria.DAL.Models
{
    public class CommandLine
    {
        [Key]
        public int Id { get; set; }

        public int CommandeId { get; set; }

        public int PizzaId { get; set; }

        public int Quantite { get; set; }

        // Navigation Properties
        [ForeignKey(nameof(PizzaId))]
        public Pizza Pizza { get; set; } = null!;

        [ForeignKey(nameof(CommandeId))]
        public Commande Commande { get; set; } = null!;
    }
}
