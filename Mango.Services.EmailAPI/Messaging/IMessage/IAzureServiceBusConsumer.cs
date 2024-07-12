namespace Mango.Services.EmailAPI.Messaging.IMessage;

public interface IAzureServiceBusConsumer
{
    Task Start();
    Task Stop();
}
