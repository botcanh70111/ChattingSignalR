using Core.Model;

namespace Core.IRepositories
{
    public interface IRoleRepository
    {
        Role GetRoleById(string id);
        Role AddRole(Role newRole);

    }
}
