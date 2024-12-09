using System.ComponentModel.DataAnnotations;

namespace Pizzeria.DAL.Models
{
    public class Ingredient
    {
        [Key]
        public int Id { get; set; }
        public string Nom { get; set; } = null!;
        public bool Allergene { get; set; }
        public List<Pizza> Pizzas { get; set; } = null!;
    }
}
