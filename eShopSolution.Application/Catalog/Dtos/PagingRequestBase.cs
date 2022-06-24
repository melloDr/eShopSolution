using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Application.Catalog.Dtos
{
    public class PagingRequestBase //Thằng này là cố định, khỏi phải truyền vào
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
}
