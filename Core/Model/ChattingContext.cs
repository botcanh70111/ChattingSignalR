using Core.Migrations;
using System.Data.Entity;

namespace Core.Model
{
    public class ChattingContext : DbContext
    {
        public ChattingContext() : base("name=ChattingConnection")
        {
            Database.SetInitializer<ChattingContext>(new CreateDatabaseIfNotExists<ChattingContext>());
            DbSeed.InsertBaseRoles();
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Message> Messages { get; set; }
    }
}
