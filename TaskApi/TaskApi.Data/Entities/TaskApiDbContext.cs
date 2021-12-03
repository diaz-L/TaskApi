using System;
using System.Drawing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TaskApi.Data.Entities.Configurations;

namespace TaskApi.Data.Entities
{
    public class TaskApiDbContext : DbContext
    {
        public TaskApiDbContext(DbContextOptions<TaskApiDbContext> options) : base(options)
        {
        }

        public DbSet<Task> Tasks { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new TaskEntityTypeConfiguration());
        }
    }
}