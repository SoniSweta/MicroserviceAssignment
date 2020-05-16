using Microservices.OMS.Orders.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservices.OMS.Orders.Repository
{
    public interface IOrderRepository
    {
        List<Order> GetAll();
        Order GetById(int id);
    }
}
