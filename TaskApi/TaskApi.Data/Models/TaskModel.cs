using System;
using TaskApi.Data.Entities;

namespace TaskApi.Data.Models
{
    public class TaskModel
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public bool HasCompleted { get; set; } 
        public DateTime LastModified { get; set; }
        public Category Category { get; set; }
    }
}