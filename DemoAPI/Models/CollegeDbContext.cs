using Microsoft.EntityFrameworkCore;

namespace DemoAPI.Models
{
    public class CollegeDbContext:DbContext
    {
        public CollegeDbContext(DbContextOptions<CollegeDbContext> options) : base(options) 
        {
            
        }
        DbSet<College> Colleges { get; set; }
    }
}
