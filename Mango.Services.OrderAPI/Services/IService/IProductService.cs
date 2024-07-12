using Mango.Services.OrderAPI.Models.Dto;

namespace Mango.Services.OrderAPI.Services.IService;

public interface IProductService
{
    Task<IEnumerable<ProductDto>> GetProducts();
}
