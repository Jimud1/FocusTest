using Microsoft.AspNet.Identity.EntityFramework;
using FirstCentral.Settings.FocusSettings;
using System.Data.Entity;
using FirstCentral.Data.Entities.Focus;

namespace FirstCentral.Data.FocusData
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base(Config.DefaultConnectionString)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<CustomerEntity> Customers { get; set; }
    }
}
