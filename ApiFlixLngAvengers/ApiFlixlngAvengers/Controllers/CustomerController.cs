using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiFlixLngAvengers.data;
using ApiFlixlngAvengers.Requests;
using ApiFlixLngAvengers.model;
using ApiFlixLngAvengers.data.Interface;

namespace ApiFlixlngAvengers.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : Controller
    {
        private readonly IApiFlixLngAvengersDbContext _avengersDbContext;

        public CustomerController(IApiFlixLngAvengersDbContext avengersDbContext)
        {
            _avengersDbContext = avengersDbContext;

        }
        [HttpPost]
        [Route("SaveCustomer")]
        public IActionResult SaveCustomer(CustomerRequest request)
        {

            Customer obj = new Customer()
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                MobNum = request.MobNum,
                Email = request.Email,
                UserName = request.UserName,
                Password = request.Password

            };
            Subscription obj1 = new Subscription()
            {
                Name = request.UserName
            };
            _avengersDbContext.Customer.Add(obj);
          //  _avengersDbContext.Subscription.Add(obj1);

            _avengersDbContext.SaveChanges();

            return Ok();
        }
        [HttpPost]
        [Route("SaveSubscription")]
        public IActionResult SaveSubscription(SubscriptionRequest request)
        {

            Subscription obj = new Subscription()
            {
                Name = request.Name
            };
          //  _avengersDbContext.Subscription.Add(obj);
            _avengersDbContext.SaveChanges();

            return View();
        }

       
    }
}
