namespace Mango.MessageBus.Messages.IMessage;
public interface IMessageBus
{
    Task PublishMessage(object message, string topic_queue_Name);
}
