using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTCData.Services
{
   public class PTCContext : DbContext
    {
        public DbSet<TrainingProduct> TrainingProducts { get; set; }
    }
}
