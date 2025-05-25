using PTD_KTRA.Models;
using Microsoft.EntityFrameworkCore;

namespace PTD_KTRA.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
        public DbSet<Test> Test { get; set; } = default!;
    }

}