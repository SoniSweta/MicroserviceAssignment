using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microservices.OMS.Users.Entities;
using Microservices.OMS.Users.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Microservices.OMS.Users.Controllers
{
    [Route("api/user")]
    public class UserController : Controller
    {
        public IUserRepository userRepository;

        public UserController(IUserRepository _userRepository)
        {
            userRepository = _userRepository;
        }

        // GET: api/<controller>
        [HttpGet]
        public IActionResult Get()
        {
            List<User> userList = userRepository.GetAll();
            return new JsonResult(userList);
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            User user = userRepository.GetById(id);
            return new JsonResult(user);
        }

    }
}
