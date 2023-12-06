using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class TeamsContext : DbContext
    {
        public string connectionString = @"Data Source=DESKTOP-H53LSCO;Initial Catalog=""Football match"";Integrated Security=True;Encrypt=False";
        public DbSet<Teams> Teams { set; get; }

        public TeamsContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
