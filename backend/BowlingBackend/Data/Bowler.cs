using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace BowlingBackend.Data
{
    public class Bowler
    {
        [Key]
        [Required]
        public int BowlerID { get; set; }
        public string? BowlerLastName { get; set; }
        public string? BowlerFirstName { get; set; }
        public string? BowlerMiddleInit {  get; set; }
        public string? BowlerAddress { get; set; }
        public string? BowlerCity { get; set; }
        public string? BowlerState { get; set; }
        public string? Bowlerzip {  get; set; }
        public string? BowlerPhoneNumber { get; set; }

        [ForeignKey("TeamID")]
        public int? TeamID { get; set; }
        public Team? Teams { get; set; }
    }
}
