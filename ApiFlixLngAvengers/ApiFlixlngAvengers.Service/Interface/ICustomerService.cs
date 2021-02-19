using ApiFlixlngAvengers.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiFlixlngAvengers.Service.Interface
{
    public interface ICustomerService
    {
      int SaveCustomer(CustomerRequest request);
    }
}
