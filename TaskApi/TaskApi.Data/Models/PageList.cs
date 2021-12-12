using System;
using System.Collections.Generic;
using System.Linq;

namespace TaskApi.Data.Models
{
    public class PageList<T> : List<T>
    {
        private const int MaxPageSize = 50;
        private int _currentPage;
        public int CurrentPage { get => _currentPage; private set => _currentPage = (value <= 0) ? 1 : value; }

        public int TotalPages { get; private set; }
        
        private int _pageSize;

        public int PageSize
        {
            get => _pageSize;
            private set => _pageSize = (value > MaxPageSize) ? MaxPageSize : value;
        }

        public bool HasNext { get => CurrentPage < TotalPages; }
        public bool HasPrevious { get => CurrentPage > 1; }

        private PageList(IEnumerable<T> items, int page, int pageSize, int count)
        {
            CurrentPage = page;
            PageSize = pageSize;
            TotalPages = (int) Math.Ceiling((double) count / PageSize);
            AddRange(items);
        }

        public static PageList<T> ToPageList(IQueryable<T> source, int page, int pageSize)
        {   
            return new PageList<T>(source
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                , page, pageSize, source.Count());
        }
    }
}