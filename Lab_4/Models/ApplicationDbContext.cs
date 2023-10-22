using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Lab_4.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Trainer> Trainers { get; set; }
    }
}
