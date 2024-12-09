using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Pizzeria.DAL.Models
{
    //[Index(nameof(Nom))]
    public class Client
    {
        [Key]
        public int Id { get; set;}

        public string Nom { get; set; } = null!;
        public string Prenom { get; set; } = null!;
        public List<Commande> Commandes { get; set; } = null!;
        public List<Adresse> Adresses { get; set; } = null!;
    }
}
