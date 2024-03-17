using System.ComponentModel.DataAnnotations;

namespace BowlingBackend.Data
{
    public class Team
    {
        [Key]
        public int TeamID { get; set; }
        public string? TeamName { get; set; }
    }
}
