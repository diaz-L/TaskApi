using System;
using System.ComponentModel;

namespace TaskApi.Data.Models
{
    public class TaskForCreationModel
    {
        public string Body { get; set; }
        public bool HasCompleted { get; set; }
        public int CategoryId { get; set; }
    }
}