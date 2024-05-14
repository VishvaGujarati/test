using System.ComponentModel.DataAnnotations;

namespace test.Models.entity
{
    public class v1
    {
        [Key]
        public int pid { get; set; }
        [Required]
        public int lid { get; set; }
        [Required]
        public String ptype {  get; set; }
        [Required]
        public int tarea { get; set; }
        [Required]
        public String location { get; set; }
        [Required]
        public int rent { get; set; }
    }
}
