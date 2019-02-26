using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LMS_Na18.Models
{
    public class LMS_Na18Context : DbContext
    {
        public LMS_Na18Context (DbContextOptions<LMS_Na18Context> options)
            : base(options)
        {
        }

        public DbSet<LMS_Na18.Models.Person> Person { get; set; }
    }
}
