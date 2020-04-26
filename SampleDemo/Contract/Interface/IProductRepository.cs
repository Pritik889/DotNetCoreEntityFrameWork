using System.Collections.Generic;
using System.Threading.Tasks;
using SampleDemo.Contract.Model.Repository;

namespace SampleDemo.Contract.Interface
{
   public  interface IProductRepository
   {
       Task<IEnumerable<ProductDto>> GetProductByProductTypeIdAsync(int productTypeId);
   }
}
