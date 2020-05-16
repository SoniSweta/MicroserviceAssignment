using Microservices.OMS.Orders.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservices.OMS.Orders.Repository
{
    public class OrderRepository: IOrderRepository
    {
        List<Order> orderList = new List<Order>();

        public OrderRepository()
        {
            orderList.Add(new Order { Id = 1, OrderAmount = 250, OrderDate = new DateTime(2020, 05, 14) });
            orderList.Add(new Order { Id = 2, OrderAmount = 550, OrderDate = new DateTime(2020, 05, 15) });
        }

        public Order GetById(int id)
        {
            Order order = orderList.Where(x => x.Id == id).FirstOrDefault();
            return order;
        }

        public List<Order> GetAll()
        {
            return this.orderList;
        }
    }
}
