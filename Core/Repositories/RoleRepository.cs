using Core.IRepositories;
using Core.Model;
using System.Data.Entity;
using System.Linq;

namespace Core.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private ChattingContext _context;
        public RoleRepository(ChattingContext context)
        {
            _context = context;
        }
        public Role AddRole(Role newRole)
        {
            _context.Roles.Add(newRole);
            _context.SaveChanges();

            return newRole;
        }

        public Role GetRoleById(string id)
        {
            return _context.Roles.Where(x => x.RoleId.ToString() == id).FirstOrDefault() ?? null;
        }
    }
}
