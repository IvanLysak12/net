using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Character> Characters => Set<Character>();
    }
}