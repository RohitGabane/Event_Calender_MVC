using Microsoft.EntityFrameworkCore;

namespace Event_Calender_MVC.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext()
        {

        }

        public MyDbContext(DbContextOptions<MyDbContext> options)  : base(options) 
        {
            
        }
        public DbSet<Event> Event { get; set; }
    }
}
