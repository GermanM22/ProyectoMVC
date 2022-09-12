using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class WebApplication2DbContext : DbContext
    {
        public DbSet<Hospital> Hospitals { get; set; }

        public DbSet<Patient> Patients { get; set; }

        public WebApplication2DbContext(DbContextOptions<WebApplication2DbContext> options) : base(options)
        {

        }
    }
}