using ApiFlixlngAvengers.Requests;
using ApiFlixlngAvengers.Service.Interface;
using ApiFlixLngAvengers.data.Interface;
using ApiFlixLngAvengers.model;
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

        public int SaveCustomer(CustomerRequest request) 
        {

            Customer customerobj = new Customer()
            {
                
                FirstName = request.FirstName,
                LastName = request.LastName,
                MobileNumber = request.MobileNumber,
                Email = request.Email,
                UserName = request.UserName,
                Password = request.Password,
                ConfirmPassword = request.ConfirmPassword,
            };
            _avengersDbContext.Customer.Add(customerobj);
            
            
            _avengersDbContext.SaveChanges();

            return customerobj.Id;

        }

        

        
    }
}
