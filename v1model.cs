using System.ComponentModel.DataAnnotations;

namespace test.Models
{
    public class v1model
    {

        [Key]
        public int pid { get; set; }
        [Required]
        public int lid { get; set; }
        [Required]
        [RegularExpression("^[a-zA-Z]{1,}$", ErrorMessage = "Enter only Characters")]
        public String ptype { get; set; }
        [Required]
        [RegularExpression("^[0-9]{1,}$", ErrorMessage = "Enter only numbers")]
        public int tarea { get; set; }
        [Required]
        [RegularExpression("^[a-zA-Z]{1,}$", ErrorMessage = "Enter only Characters")]
        public String location { get; set; }
        [Required]
        [RegularExpression("^[0-9]{1,}$", ErrorMessage = "Enter only numbers")]
        public int rent { get; set; }
    }
}