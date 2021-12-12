using System;
using System.Collections.Generic;
using System.Linq;

namespace TaskApi.Data.Models
{
    public class PageList<T> : List<T>
    {
        public int CurrentPage { get; private set; }
        public int TotalPages { get; private set; }
        public int PageSize { get; private set; }
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