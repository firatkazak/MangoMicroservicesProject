using AutoMapper;
using Mango.Services.CouponAPI.Models.Dto;
using Mango.Services.CouponAPI.Models.Model;

namespace Mango.Services.CouponAPI.Mapping;

public class MappingConfig
{
    public static MapperConfiguration RegisterMaps()
    {
        var mappingConfig = new MapperConfiguration(config =>
        {
            config.CreateMap<Coupon, CouponDto>().ReverseMap();
        });

        return mappingConfig;
    }
}
