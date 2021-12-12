namespace TaskApi.Data.ResourceParameters
{
    public class TaskQueryParameters
    {
        private const int MaxPageSize = 25;
        
        public string Category { get; set; }
        public int Page { get; set; } = 1;

        private int _pageSize = 10;
        
        public int PageSize
        {
            get => _pageSize; 
            set => _pageSize = (value > MaxPageSize) ? MaxPageSize : value;
        }
    }
}