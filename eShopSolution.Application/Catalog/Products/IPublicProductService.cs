using System;
using System.Collections.Generic;
using System.Text;
using eShopSolution.Application.Catalog.Dtos;
using eShopSolution.Application.Catalog.Products.Dtos;

namespace eShopSolution.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        PagedViewModel<ProductViewModel> GetAllByCategoryId(int CategoryId, int PageIndex, int PageSize);
    }
}
