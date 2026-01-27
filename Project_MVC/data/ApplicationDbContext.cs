using Microsoft.EntityFrameworkCore;

namespace Project_MVC.data
{
    public class ApplicationDbContext : DbContext

    {



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {
            base.OnConfiguring(optionsBuilder);
            // database for production
            optionsBuilder.UseSqlServer("Server = db39201.public.databaseasp.net; Database=db39201; User Id = db39201; Password=W_n7?5Xqg-3Q; Encrypt=True; TrustServerCertificate=True; MultipleActiveResultSets=True; ");

                //database for dev
 
             //optionsBuilder.UseSqlServer("Server = DESKTOP-DK2469P; Database=MVC_Project;TrustServerCertificate = True;Trusted_Connection=True");
        }
    }
}

