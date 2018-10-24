using System;
using System.Collections.Generic;
using Core.IRepositories;
using Core.Model;

namespace Core.Repositories
{
    public class MessageRepository : IMessageRepository
    {
        public List<Message> GetMessages()
        {
            throw new NotImplementedException();
        }

        public List<Message> GetMessagesByCurrentUser()
        {
            throw new NotImplementedException();
        }

        public List<Message> GetMessagesByDestinationId()
        {
            throw new NotImplementedException();
        }
    }
}
