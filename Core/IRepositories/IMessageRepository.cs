using System.Collections.Generic;
using Core.Model;

namespace Core.IRepositories
{
    public interface IMessageRepository
    {
        List<Message> GetMessages();
        List<Message> GetMessagesByCurrentUser();
        List<Message> GetMessagesByDestinationId();
    }
}
