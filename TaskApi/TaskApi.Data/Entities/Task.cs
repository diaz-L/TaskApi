using System;

namespace TaskApi.Data.Entities
{
    public class Task
    {
        public int TaskId { get; set; }
        public string Body { get; set; }
        public bool HasCompleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastModified { get; set; }
        
        
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}