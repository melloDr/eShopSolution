using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Application.Catalog.Products.Dtos
{
    public class ProductCreateRequest //Thằng này là đầu vào!, cái function mà cần thứ gì để xử lý thì thằng này phải khai báo
    {
        public string Name { get; set;  }
        public decimal Price { get; set;  }
    }
}
