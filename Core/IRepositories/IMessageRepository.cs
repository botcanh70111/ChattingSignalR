using Core.Model;
using System.Collections.Generic;

namespace Core.IRepositories
{
    public interface IMessageRepository
    {
        List<Message> GetMessages();
        List<Message> GetMessagesByCurrentUser();
        List<Message> GetMessagesByDestinationId();
    }
}
