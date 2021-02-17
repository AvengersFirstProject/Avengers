using System;
using System.Collections.Generic;
using System.Text;

namespace ApiFlixlngAvengers.Service.Interface
{
    public interface ICustomerService
    {
        IActionResult SaveUser(CustomerRequest request);
    }
}
