using ApiFlixlngAvengers.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiFlixlngAvengers.Service.Implement
{
    public class CustomerService : ICustomerService
    {
        private readonly IApiFlixLngAvengersDbContext _avengersDbContext;

        public CustomerService(IApiFlixLngAvengersDbContext avengersDbContext)
        {
            _avengersDbContext = avengersDbContext;

        }

        public IActionResult SaveCustomer(CustomerRequest request)
        {

            Customer customerobj = new Customer()
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                MobNum = request.MobNum,
                Email = request.Email,
                UserName = request.UserName,
                Password = request.Password

            };
            _avengersDbContext.Customer.Add(customerobj);
            

            _avengersDbContext.SaveChanges();

        }
        IActionResult ICustomerService.SaveUser(UsersRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
