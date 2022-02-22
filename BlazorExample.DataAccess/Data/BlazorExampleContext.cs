using Microsoft.EntityFrameworkCore;

namespace BlazorExample.DataAccess.Data
{
    public class BlazorExampleContext : DbContext
    {
        public BlazorExampleContext(DbContextOptions<BlazorExampleContext> options) : base(options)
        {

        }

        public DbSet<Course> Courses { get; set; }
    }
}
