
using System.ComponentModel.DataAnnotations;

namespace Demo02.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Range(1, int.MaxValue)]
        public int Quatity {  get; set; }

        public string? ImagePath{ get; set; }
    }
}
