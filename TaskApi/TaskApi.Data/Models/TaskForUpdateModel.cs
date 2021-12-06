namespace TaskApi.Data.Models
{
    public class TaskForUpdateModel
    {
        public string Body { get; set; }
        public bool HasCompleted { get; set; }
        public int CategoryId { get; set; }
    }
}