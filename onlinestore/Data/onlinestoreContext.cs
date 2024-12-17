using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using onlinestore.Models;

namespace onlinestore.Data
{
    public class onlinestoreContext : DbContext
    {
        public onlinestoreContext (DbContextOptions<onlinestoreContext> options)
            : base(options)
        {
        }

        public DbSet<onlinestore.Models.User> User { get; set; } = default!;
    }
}
