using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SampleDemo.Contract.Interface;
using SampleDemo.Contract.Model.Repository;
using SampleDemo.Repository.Data;

namespace SampleDemo.Repository
{
    public class ProductRepository: IProductRepository
    {
        private readonly DataContext _dataContext;

        public ProductRepository()
        {
            _dataContext = new DataContext();
        }

        public async Task<IEnumerable<ProductDto>> GetProductByProductTypeIdAsync(int productTypeId)
        {
            var query = from pr in _dataContext.Products
                where pr.ProductTypeId == productTypeId
                select new ProductDto
                {
                    Name = pr.Name,
                    ShortDescription = pr.ShortDescription,
                    FullDescription = pr.FullDescription,
                    ProductTypeId = pr.ProductTypeId,
                    Price = pr.Price
                };
            var productDetail =await query.ToArrayAsync().ConfigureAwait(false);

            return productDetail;
        }
    }
}
