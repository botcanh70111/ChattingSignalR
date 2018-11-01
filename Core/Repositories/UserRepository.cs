using Core.Model;
using Core.IRepositories;
using Core.ViewModels;

namespace Core.Repositories
{
    public class UserRepository : IUserRepository
    {
        private ChattingContext _context;
        public UserRepository(ChattingContext context)
        {
            _context = context;
        }
        public User CreateUser(UserViewModel newUser)
        {
            var hashedPass = HashLibrary.HashedPassword.New(newUser.Password);
            var hash = hashedPass.Hash;
            var salt = hashedPass.Salt;
            var user = new User
            {
                UserName = newUser.UserName,
                Email = newUser.Email,
                HashPassword = hash,
                SaltPassWord = salt,

            };
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }

        public User EditUser(string oldUserId, UserViewModel newUser)
        {
            throw new System.NotImplementedException();
        }

        public User GetCurrentUser()
        {
            throw new System.NotImplementedException();
        }

        public User GetUserById(string id)
        {
            throw new System.NotImplementedException();
        }
    }
}
