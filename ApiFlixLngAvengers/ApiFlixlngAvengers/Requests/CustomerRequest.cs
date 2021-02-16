using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFlixlngAvengers.Requests
{
    public class CustomerRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int MobNum { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }

        public string Password { get; set; }
       
    }
    public class SubscriptionRequest
    {
        public string Name{ get; set; }
    }
}
