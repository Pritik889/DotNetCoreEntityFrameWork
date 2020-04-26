using System.Collections.Generic;
using System.Threading.Tasks;
using SampleDemo.Contract.Model.Business;

namespace SampleDemo.Contract.Interface.Business
{
    public interface IProduct
    {
        Task<IEnumerable<Product>> GetProductByProductTypeIdAsync(int productTypeId);
    }
}
