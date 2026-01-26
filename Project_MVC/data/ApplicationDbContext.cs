using Microsoft.EntityFrameworkCore;

namespace Project_MVC.data
{
    public class ApplicationDbContext : DbContext

    {



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server = DESKTOP-DK2469P; Database=MVC_Project;TrustServerCertificate = True;Trusted_Connection=True");
        }
    }
}

