using Pizzeria.DAL.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pizzeria.DAL.Models
{
    public class Commande
    {
        [Key]
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime Date { get; set; }
        public CommandeStatut Statut { get; set; }

        // navigation properties
        [ForeignKey(nameof(ClientId))]
        public Client Client { get; set; } = null!;
    }
}
