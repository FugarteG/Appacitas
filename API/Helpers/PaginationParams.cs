using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Helpers
{
    public class PaginationParams
    {
          private const int MaxpageSize = 50;
        public int PageNumber { get; set; }
        private int _pageSize = 10;

        public int PageSize
        {
            get => _pageSize;
            set => _pageSize = (value > MaxpageSize) ? MaxpageSize : value;
        }
    }
}