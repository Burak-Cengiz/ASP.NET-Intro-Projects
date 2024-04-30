using System.ComponentModel.DataAnnotations;

namespace BlazorIntro2.Models
{
    public class ProductAddModel
    {
        [Required(ErrorMessage ="Ürün adı zorunludur")]
        [StringLength(20,ErrorMessage ="Ürün ismi karakter sayısını geçemez")]
        public string ProductName { get; set; }
        [Required]
        [StringLength(40)]
        public string Description { get; set; }
        [Required]
        public string CategoryId { get; set; }
    }
}
