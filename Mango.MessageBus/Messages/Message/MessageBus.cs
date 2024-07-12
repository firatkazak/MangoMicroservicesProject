using Azure.Messaging.ServiceBus;
using Mango.MessageBus.Messages.IMessage;
using Newtonsoft.Json;
using System.Text;

namespace Mango.MessageBus.Messages.Message;
public class MessageBus : IMessageBus
{
    private string connectionString = "Endpoint=sb://firatapidersleri.servicebus.windows.net/;SharedAccessKeyName=apidersleri;SharedAccessKey=DH6Nihd1lBKNe7P8sp901Nwm3xFUEs31/+ASbHZbfhc=;EntityPath=emailshoppingcart";
    public async Task PublishMessage(object message, string topic_queue_Name)
    {
        await using var client = new ServiceBusClient(connectionString);

        ServiceBusSender sender = client.CreateSender(topic_queue_Name);

        var jsonMessage = JsonConvert.SerializeObject(message);
        ServiceBusMessage finalMessage = new ServiceBusMessage(Encoding
            .UTF8.GetBytes(jsonMessage))
        {
            CorrelationId = Guid.NewGuid().ToString(),
        };

        await sender.SendMessageAsync(finalMessage);
        await client.DisposeAsync();
    }
}
