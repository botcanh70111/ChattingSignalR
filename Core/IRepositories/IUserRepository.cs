using Core.Model;
using Core.ViewModels;

namespace Core.IRepositories
{
    public interface IUserRepository
    {
        User GetCurrentUser();
        User GetUserById(string id);
        User CreateUser(UserViewModel newUser);
        User EditUser(string oldUserId, UserViewModel newUser);
    }
}
