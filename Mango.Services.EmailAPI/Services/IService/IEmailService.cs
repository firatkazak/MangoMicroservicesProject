using Mango.Services.EmailAPI.Messages;
using Mango.Services.EmailAPI.Models.Dto;

namespace Mango.Services.EmailAPI.Services.IService;

public interface IEmailService
{
    Task EmailCartAndLog(CartDto cartDto);
    Task RegisterUserEmailAndLog(string email);
    Task LogOrderPlaced(RewardsMessage rewardsDto);
}
