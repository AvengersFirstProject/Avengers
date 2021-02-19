using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApliFlixLngAvengers.model.Requests
{
   public enum subtype
    {
       HalfYearly = 1,
        Yearly = 2,
        Quaterly = 3
    }

    public class SubscriptionRequest
    {
        public subtype SubscriptionType { get; set; }
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

    }
}
