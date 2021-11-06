using Microsoft.EntityFrameworkCore;
using NetChat.Domain;
using System;

namespace NetChat.Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Channel> Channels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Channel>()
                .HasData(new Channel
                {
                    Id = Guid.NewGuid(),
                    Name = "DotNetCore",
                    Description = "Dedicated channel to NetCore"
                },
                new Channel {
                    Id = Guid.NewGuid(),
                    Name = "Reac JS",
                    Description = "Dedicated channel to ReacJS"
                },
                new Channel {
                    Id = Guid.NewGuid(),
                    Name = "Angular",
                    Description = "Dedicated channel to Angular"
                });
        }
    }
}
