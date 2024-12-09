using System.ComponentModel.DataAnnotations;

namespace Pizzeria.DAL.Models
{
    public class Pizza
    {
        [Key]
        public int Id { get; set; }
        public string Nom { get; set; } = null!;
        public decimal Prix { get; set; }
        public List<Ingredient> Ingredients { get; set; } = null!;
        public List<CommandLine> CommandLines { get; set; } = null!;
    }
}
