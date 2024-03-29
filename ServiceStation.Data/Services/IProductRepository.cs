﻿using ServiceStation.Core.Shop;
using ServiceStation.Data.Paging;
using System.Threading.Tasks;

namespace ServiceStation.Data.Services
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        Task<PagedList<Product>> GetProducts(PagingParameters pagingParameters, string sortOrder, string searchString);
        Product GetProduct(int id);
        void CreateProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);
    }
}
