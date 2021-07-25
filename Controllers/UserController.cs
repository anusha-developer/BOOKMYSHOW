using BOOKMYSHOW.Models;
using BOOKMYSHOW.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BOOKMYSHOW.Controllers
{
    public class UserController : ApiController
    {
        private UserService userService;
        public UserController()
        {
            userService = new UserService();
        }

        [HttpPost]
        [Route("api/User/save")]
        public User saveProduct([FromBody] User user)
        {

            try
            {
                return userService.SaveUser(user);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return user;
        }
        [HttpGet]
        [Route("api/User/GetById/{user_id}")]
        public User fetchUserById(int user_id)
        {
            try
            {
                return userService.GetUserById(user_id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
        [HttpGet]
        [Route("api/User/GetAll")]
        public List<User> fetchAllUsers()
        {
            try
            {
                return userService.GetAllUsers();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
        [HttpGet]
        [Route("api/User/GetUserByName/{username}")]
        public User fetchUserByName(string username)
        {
            try
            {
                return userService.GetUserByUsername(username);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
        [HttpPut]
        [Route("api/User/Update/{user_id}")]
        public User UpdateUser(long user_id, User user)
        {
            try
            {
                return userService.UpdateUser(user_id,user);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
        [HttpDelete]
        [Route("api/User/DeleteById/{user_id}")]
        public string DeleteUser(long user_id)
        {
            try
            {
                return userService.DeleteUser(user_id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
        [HttpGet]
        [Route("api/User/Login/{email}/{password}")]
        public User LoginUser(string email, string password)
        {
            try
            {
                return userService.ValidateUser(email, password);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

    }
}
