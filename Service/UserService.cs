using BOOKMYSHOW.Models;
using BOOKMYSHOW.Repositary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BOOKMYSHOW.Service
{
    public class UserService
    {
        private UserRepositaryimpl userRepositaryimpl;
        
        public UserService()
        {
            userRepositaryimpl = new UserRepositaryimpl();
        }
        public User SaveUser(User user)
        {
            return userRepositaryimpl.CreateUser(user);
        }
        public User GetUserById(long user_id)
        {
            return userRepositaryimpl.GetUserById(user_id);
        }
        public List<User> GetAllUsers()
        {
            return userRepositaryimpl.GetAllUsers();
        }
        public User GetUserByUsername(string username)
        {
            return userRepositaryimpl.GetUserByUsername(username);
        }
        public User UpdateUser(long user_id, User user)
        {
            return userRepositaryimpl.UpdateUser(user_id,user);
        }
        public string DeleteUser(long user_id)
        {
            return userRepositaryimpl.DeleteUser(user_id);
        }
        public User ValidateUser(string email, string password)
        {
            return userRepositaryimpl.LoginUser(email, password);
        }

    }
}