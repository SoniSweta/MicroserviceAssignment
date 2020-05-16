using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microservices.OMS.Orders.Model;
using Microservices.OMS.Orders.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Microservices.OMS.Orders.Controllers
{
    [Route("api/order")]
    public class OrderController : Controller
    {
        public IOrderRepository orderRepository;

        public OrderController(IOrderRepository _orderRepository)
        {
            orderRepository = _orderRepository;
        }

        // GET: api/<controller>
        [HttpGet]
        public IActionResult Get()
        {
            List<Order> orderList = orderRepository.GetAll();
            return new JsonResult(orderList);
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Order order = orderRepository.GetById(id);
            return new JsonResult(order);
        }

    }
}
