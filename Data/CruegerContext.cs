using crueger.Models;
using Microsoft.EntityFrameworkCore;

namespace crueger.Data
{
    public class CruegerContext : DbContext
    {
        public CruegerContext(DbContextOptions<CruegerContext> opt) : base(opt)
        {
            
        }

        public DbSet<Command> Commands { get; set; }
    }
}