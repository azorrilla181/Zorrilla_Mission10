using System.ComponentModel.DataAnnotations;

namespace Zorrilla_Mission10.Data
{
    public class TeamsClass
    {
        [Key]
        public int TeamID { get; set; }
        [Required]
        public string TeamName { get; set; }
        public int CaptainID { get; set; }
    }
}
