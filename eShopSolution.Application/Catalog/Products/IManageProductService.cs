using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using eShopSolution.Application.Catalog.Dtos;
using eShopSolution.Application.Catalog.Products.Dtos;

namespace eShopSolution.Application.Catalog.Products
{
    public interface IManageProductService 
    {
        Task<int> Create(ProductCreateRequest request); // Thằng task giúp nó chạy theo tuần tự, không chen lấn 

        Task<int> Update(ProductUpdateRequest request);
        Task<int> Delete(int productId);
        Task<List<ProductViewModel>> GetAll();
        Task<PagedResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request);
    }
}
