using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NebulaToDo.Models
{
    public class NebulaDbContext : DbContext
    {
        public NebulaDbContext()
        {
        }

        public NebulaDbContext(DbContextOptions<NebulaDbContext> options) : base(options)
        {

        }

        public DbSet<USERS> USER { get; set; }

        public DbSet<TASK_DETAILS> TASK_DETAIL { get; set; }

        public DbSet<STATUSES> STATUS { get; set; }
    }
}
