using Microsoft.EntityFrameworkCore;
using Net.Core.Demo.Web.Models;

namespace Net.Core.Demo.Web.Storage
{
    public class DemoAppContext : DbContext
    {
        public DemoAppContext(DbContextOptions<DemoAppContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}