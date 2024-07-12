using Mango.Services.RewardAPI.Messages;

namespace Mango.Services.RewardAPI.Services.IService;

public interface IRewardService
{
    Task UpdateRewards(RewardsMessage rewardsMessage);
}
