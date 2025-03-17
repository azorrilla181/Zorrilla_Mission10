using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zorrilla_Mission10.Data
{
    public class BowlerCLass
    {
        [Key] [Required]
        public int BowlerID { get; set; }
        [Required]
        public string BowlerLastName { get; set; }
        [Required]
        public string BowlerFirstName { get; set; }
        public string? BowlerMiddleInit { get; set; }
        [Required]
        public string BowlerAddress { get; set; }
        [Required]
        public string BowlerCity { get; set; }
        [Required]
        public string BowlerState { get; set; }
        [Required]
        public string BowlerZip { get; set; }
        [Required]
        public string BowlerPhoneNumber { get; set; }

        [ForeignKey("Team")]
        public int TeamID { get; set; }
        public TeamsClass Team { get; set; } //this needs to connect to the Teams table through TeamID
    }
}
