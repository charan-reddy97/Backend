using Books.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Core.Repository
{
    public class UserRepository : IUserRepository
    {
        BookDbContext dbContext;
        public UserRepository(BookDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public User Add(User user)
        {

            user.CreatedDate = DateTime.Now;
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
            return user;
        }

        public User Update(User user)
        {
            User currentUser = dbContext.Users.FirstOrDefault(d => d.Id == user.Id);
            if (currentUser != null)
            {
                currentUser.Name = user.Name;
                currentUser.Email = user.Email;
                currentUser.Password = user.Password;
                currentUser.Role = user.Role;
                currentUser.LastModifiedDate = DateTime.Now;


                dbContext.Users.Update(currentUser);
                dbContext.SaveChanges();

            }

            return user;
        }

        public void Delete(int userid)
        {
            User currentUser = dbContext.Users.FirstOrDefault(d => d.Id == userid);
            if (currentUser != null)
            {
                currentUser.DeletedDate = DateTime.Now;
                dbContext.Users.Update(currentUser);
                dbContext.SaveChanges();

            }
        }
        
        public User FindUserById(int userid)
        {
            var user= dbContext.Users.FirstOrDefault(d => d.Id == userid);
            if(user==null)
            {
                throw new Exception("User not exist");
            }
            return user;
        }

        public User FindByUserName(string username, string password)
        {
            return dbContext.Users.FirstOrDefault(d => d.Email == username
                                                    && d.Password == password
                                                    && d.DeletedDate == null);
        }
        public List<User> GetUsers()
        {
            return dbContext.Users.Where(d => d.DeletedDate == null).ToList();
        }
    }

}
