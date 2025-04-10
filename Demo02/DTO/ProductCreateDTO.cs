using System.ComponentModel.DataAnnotations;

namespace Demo02.DTO
{
    public class ProductCreateDTO
    {
        [Required]
        public string Name { get; set; }

        [Range(1, int.MaxValue)]
        public int Quatity { get; set; }

        public IFormFile? Image { get; set; }
    }
}
