using Microservices.OMS.Users.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservices.OMS.Users.Repository
{
    public interface IUserRepository
    {
        User GetById(int id);
        List<User> GetAll();
    }
}
