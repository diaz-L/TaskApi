namespace TaskApi.Data.ResourceParameters
{
    public class TaskQueryParameters
    {
        private const int MaxPageSize = 50;
        public string Category { get; set; }
        
        private int _page = 1;
        public int Page { get => _page; set => _page = (value <= 0) ? 1 : value; }

        private int _pageSize = 20;
        public int PageSize
        {
            get => _pageSize;
            set => _pageSize = (value > 0 && value <= MaxPageSize) ? value : MaxPageSize;
        }
    }
}