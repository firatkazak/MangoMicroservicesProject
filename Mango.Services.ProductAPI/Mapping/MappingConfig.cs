using AutoMapper;
using Mango.Services.ProductAPI.Models.Model;
using Mango.Services.ProductAPI.Models.Dto;

namespace Mango.Services.ProductAPI.Mapping;

public class MappingConfig
{
    public static MapperConfiguration RegisterMaps()
    {
        var mappingConfig = new MapperConfiguration(config =>
        {
            config.CreateMap<ProductDto, Product>().ReverseMap();
        });
        return mappingConfig;
    }
}
