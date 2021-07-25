using BOOKMYSHOW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOKMYSHOW.Repositary
{
    interface IUserRepositary
    {
        //Get User
        User CreateUser(User user);


        //Delete UserByID
        string DeleteUser(long user_id);


        //Update User By UserId
        User UpdateUser(long user_id, User user);


        //Get All Users
        List<User> GetAllUsers();


        //Get User By UserID
        User GetUserById(long user_id);


        //Get User By UserName
        User GetUserByUsername(string username);

        //LoginBY Email&Password
        User LoginUser(string email, string password);


    }
}
