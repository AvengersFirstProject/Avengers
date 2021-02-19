using ApliFlixLngAvengers.model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApliFlixLngAvengers.model.Models
{
   public class Subscription
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public subtype SubscriptionType { get; set; }
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

    }
}
