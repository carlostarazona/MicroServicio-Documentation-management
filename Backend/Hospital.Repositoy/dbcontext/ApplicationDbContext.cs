using Hospital.Entity;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Repositoy.dbcontext
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Order> Orders{ get; set; }
        public DbSet<Finalreport> Finalreports { get; set; }
        public DbSet<Machinereview> Machinereviews { get; set; }
 

        //public DbSet<Consulta> Consultas { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
         

            
                    
        }
    }
}