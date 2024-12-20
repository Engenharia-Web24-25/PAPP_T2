namespace EW_PAPP_2024.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<Person>? Persons { get; set; } // for N:N relation
    }
}
