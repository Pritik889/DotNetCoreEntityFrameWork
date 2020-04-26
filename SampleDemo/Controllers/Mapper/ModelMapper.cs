using AutoMapper;
using SampleDemo.Contract.Model.Dto;

namespace SampleDemo.Controllers.Mapper
{
    public class ModelMapper
    {
        public static readonly IMapper Mapper;

        static ModelMapper()
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<Contract.Model.Business.Product, ProductDetailsDto>(); });
            Mapper = config.CreateMapper();
        }
    }
}
