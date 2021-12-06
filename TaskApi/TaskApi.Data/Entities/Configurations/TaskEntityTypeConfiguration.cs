using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TaskApi.Data.Entities.Configurations
{
    public class TaskEntityTypeConfiguration : IEntityTypeConfiguration<Task>
    {
        public void Configure(EntityTypeBuilder<Task> builder)
        {
            builder
                .Property(t => t.CreatedOn)
                .HasDefaultValue(DateTime.Now);

            builder
                .Property(t => t.LastModified)
                .HasDefaultValue(DateTime.Now);

            builder
                .Property(t => t.CategoryId)
                .HasDefaultValue(1);
            
            builder.HasData(
                new Task
                {
                    TaskId = 1,
                    Body = "task one",
                    CreatedOn = DateTime.Now,
                    LastModified = DateTime.Now,
                    HasCompleted = false,
                    CategoryId = 1
                },
                new Task
                {
                    TaskId = 2,
                    Body = "task two",
                    CreatedOn = DateTime.Now,
                    LastModified = DateTime.Now,
                    HasCompleted = false,
                    CategoryId = 2
                },
                new Task
                {
                    TaskId = 3,
                    Body = "task three",
                    CreatedOn = DateTime.Now,
                    LastModified = DateTime.Now,
                    HasCompleted = false,
                    CategoryId = 2
                });
        }
    }
}