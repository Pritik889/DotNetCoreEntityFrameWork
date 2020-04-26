using System.Collections.Generic;
using System.Threading.Tasks;
using SampleDemo.Contract.Interface;
using SampleDemo.Contract.Interface.Business;
using SampleDemo.Contract.Model.Repository;
using SampleDemo.Repository;

namespace SampleDemo.Business
{
    public class Product : IProduct
    {
        private readonly IProductRepository _productRepository;

        public Product()
        {
            _productRepository =new ProductRepository();
        }

        public async Task<IEnumerable<Contract.Model.Business.Product>> GetProductByProductTypeIdAsync(int productTypeId)
        {
            var productDetailDto = await _productRepository.GetProductByProductTypeIdAsync(productTypeId).ConfigureAwait(false);
            var productDetail = ModelMapper.Mapper.Map<IEnumerable<ProductDto>, IEnumerable<Contract.Model.Business.Product>>(productDetailDto);
            return productDetail;
        }
    }
}
