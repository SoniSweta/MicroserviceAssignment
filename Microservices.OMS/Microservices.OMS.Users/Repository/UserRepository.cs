using Microservices.OMS.Users.EFDataContext;
using Microservices.OMS.Users.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservices.OMS.Users.Repository
{
    public class UserRepository : IUserRepository
    {
        protected OMSContext omsContext;
        protected DbSet<User> dbset;
        public UserRepository(OMSContext context)
        {
            omsContext = context;
            dbset = context.Set<User>();
        }
        public User GetById(int id)
        {
            User user = omsContext.User.Where(x => x.Id == id).FirstOrDefault();
            return user;
        }

        public List<User> GetAll()
        {
            List<User> userList = omsContext.User.ToList();
            return userList;
        }
    }
}
