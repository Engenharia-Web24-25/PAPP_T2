namespace EW_PAPP_2024.Models
{
    public class Person
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public IEnumerable<Team>? Teams { get; set; } // for N:N relation
    }
}
