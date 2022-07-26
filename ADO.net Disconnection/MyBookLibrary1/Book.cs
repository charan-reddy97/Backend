using System.ComponentModel.DataAnnotations;

namespace HelloWeb.Model
{
    public class Book
    {
       
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        [RegularExpression("^[A-Za-z ]{2,50}$"
            , ErrorMessage = "Invalid BookName")]
        public string Name { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        [RegularExpression("^[A-Za-z ]{2,50}$"
            , ErrorMessage = "Invalid Author")]
        public string Author { get; set; }
    }
}
