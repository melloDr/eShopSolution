using System;
using System.Collections.Generic;
using System.Text;
using eShopSolution.Application.Catalog.Dtos;

namespace eShopSolution.Application.Catalog.Products.Dtos
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; } //Truyền vào keyword

        public List<int> CategoryIds  { get; set; }
    }
}
