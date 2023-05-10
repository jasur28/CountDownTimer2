using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace CountDownTimer2.Data
{
    public class TimerDbContext : DbContext
    {
        public TimerDbContext(DbContextOptions<TimerDbContext> options) : base(options)
        {
            
        }
        public DbSet<TimerEntity> TimerEntities { get; set; }
    }
}
