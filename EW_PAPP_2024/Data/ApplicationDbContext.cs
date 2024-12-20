using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using EW_PAPP_2024.Models;

namespace EW_PAPP_2024.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<EW_PAPP_2024.Models.Team> Teams { get; set; } = default!;
        public DbSet<EW_PAPP_2024.Models.Person> Persons { get; set; } = default!;
    }
}
