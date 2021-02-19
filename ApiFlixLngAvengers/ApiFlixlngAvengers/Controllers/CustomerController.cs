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
using System.Net;
using ApiFlixlngAvengers.Service.Interface;
using ApliFlixLngAvengers.model.Requests;
using ApiFlixLngAvengers.Service.Interface;

namespace ApiFlixlngAvengers.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : Controller
    {
        private readonly IApiFlixLngAvengersDbContext _avengersDbContext;
        private readonly ICustomerService _CustomerService;
        
        public CustomerController(IApiFlixLngAvengersDbContext avengersDbContext,ICustomerService CustomerService)
        {
            _avengersDbContext = avengersDbContext;
            _CustomerService = CustomerService;
            

        }

        

        [HttpPost]
        [Route("SaveCustomer")]
        public ActionResult<CustomerResponse> Save(CustomerRequest request)
        {
            
            int customerId = _CustomerService.SaveCustomer(request);

            return StatusCode((int)HttpStatusCode.OK, 
                new CustomerResponse { Id=customerId});
        }

       

    }
}
