using System.Data.Entity;

namespace Core.Model
{
    class ChattingContext : DbContext
    {
        public ChattingContext()
            : base("name=ChattingConnection")
        {
        }
        public DbSet<Message> Messages { get; set; }
    }
}
