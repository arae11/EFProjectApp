using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StratbookData;

namespace StratbookData
{
    public partial class StratbookContext : DbContext
    {
        public static StratbookContext Instance { get; } = new StratbookContext();


        public DbSet<User> Users { get; set; }
        public DbSet<Strategy> Strategies { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Map> Maps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=TheStratbook;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }
    }
}
