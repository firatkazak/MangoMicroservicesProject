namespace Mango.Services.RewardAPI.Messaging.IMessage;

public interface IAzureServiceBusConsumer
{
    Task Start();
    Task Stop();
}
