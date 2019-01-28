using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MoodMeApp.Models
{
    public class AppDbContext: DbContext
    {
        public DbSet<Signup> userAccount { get; set;}
    }
}
