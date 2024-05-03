using shopapp.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopapp.business.Abstract
{
    public interface IProductService : IValidator<Product>
    {
        Product GetById(int id);
        Product GetProductDetails(string url);
        Product GetByIdWithCategories(int id);
        List<Product> GetProductsByCategory(string name, int page, int pageSize);
        List<Product> GetAll();
        bool Create(Product entity);
        void Update(Product entity);
        bool Update(Product entity, int[] categoryIds);
        void Delete(Product entity);
        List<Product> GetHomePageProducts();
        List<Product> GetSearchResult(string searchString);
        int GetCountByCategory(string category);
    }
}
