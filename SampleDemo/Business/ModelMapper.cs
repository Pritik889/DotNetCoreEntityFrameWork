using AutoMapper;
using SampleDemo.Contract.Model.Repository;

namespace SampleDemo.Business
{
    public class ModelMapper
    {
        public static readonly IMapper Mapper;

        static ModelMapper()
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<ProductDto, Contract.Model.Business.Product>(); });
            Mapper = config.CreateMapper();
        }

    }
}
