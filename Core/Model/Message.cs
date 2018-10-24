using System;

namespace Core.Model
{
    public class Message
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid WithDestinationId { get; set; }
        public string Messages { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
