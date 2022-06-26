using AddressBookMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace AddressBookMVC.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        //    var builder = new ConfigurationBuilder()
        //        .SetBasePath(Directory.GetCurrentDirectory())
        //        .AddJsonFile("appsettings.json");
        //    var config = builder.Build();

        //    options.UseNpgsql(config.GetConnectionString("DefaultConnection"));
        //}

        public DbSet<Contact> Contacts { get; set; }



    }
}
