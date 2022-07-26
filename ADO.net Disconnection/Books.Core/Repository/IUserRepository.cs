using Books.Core.Entities;
using System.Collections.Generic;

namespace Books.Core.Repository
{
    public interface IUserRepository
    {
        User Add(User user);
        void Delete(int userid);
        User FindByUserName(string username, string password);
        User FindUserById(int userid);
        List<User> GetUsers();
        User Update(User user);
    }
}