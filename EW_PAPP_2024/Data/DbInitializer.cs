using EW_PAPP_2024.Models;

namespace EW_PAPP_2024.Data
{
    public class DbInitializer
    {
        private ApplicationDbContext _context;

        public DbInitializer(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Run()
        {
            _context.Database.EnsureCreated();

            if (_context.Teams.Any())
            {
                return;
            }

            var _teams = new Team[]
            {
                new Team { Name = "Bloggers" },
                new Team { Name = "Book Readers" },
                new Team { Name = "Gardeners" },
                new Team { Name = "Gamers" },
                new Team { Name = "Chefs" }
            };

            _context.Teams.AddRange(_teams);

            var _persons = new Person[]
            {
                new Person { Name = "John Senna", Email = "jsenna@ew.utad.pt" , Teams =  [_teams.Single(c => c.Name == "Gamers")]},
                new Person { Name = "Peter Frank", Email = "frank@ew.utad.pt" , Teams = [_teams.Single(c => c.Name == "Bloggers"), _teams.Single(c => c.Name == "Gamers") ]},
                new Person { Name = "Joanna Best", Email = "joanna@ew.utad.pt" },
                new Person { Name = "Silvia Boris", Email = "sb@ew.utad.pt" , Teams = [_teams.Single(c => c.Name == "Bloggers"), _teams.Single(c => c.Name == "Book Readers"), _teams.Single(c => c.Name == "Gardeners") ]},
                new Person { Name = "Beth Costa", Email = "beth.costa@ew.utad.pt" ,Teams = [_teams.Single(c => c.Name == "Bloggers"), _teams.Single(c => c.Name == "Gardeners")]},
            };

            _context.Persons.AddRange(_persons);

            _context.SaveChanges();
        }
    }
}
