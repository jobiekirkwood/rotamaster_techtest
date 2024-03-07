namespace DataAccess.Models
{
    public class Shifts
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public string Role { get; set; }
        public int PersonId { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
}
