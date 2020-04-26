using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SampleDemo.Contract.Interface.Business;
using SampleDemo.Contract.Model.Dto;
using SampleDemo.Controllers.Mapper;

namespace SampleDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProduct _product;

        public ProductController(IProduct product)
        {
            _product = product;
        }

        [Route("~/api/GetProducts/{productTypeId}")]
        [HttpGet]
        public async Task<ActionResult> GetProducts(int productTypeId)
        {
            var products = await _product.GetProductByProductTypeIdAsync(productTypeId).ConfigureAwait(false);
            var productDetail = ModelMapper.Mapper.Map<IEnumerable<Contract.Model.Business.Product>, IEnumerable<ProductDetailsDto>>(products);
            return new OkObjectResult(productDetail);
        }
    }
}