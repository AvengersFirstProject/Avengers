using ApliFlixLngAvengers.model.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiFlixLngAvengers.Service.Interface
{
   public interface ISubscriptionService
    {
        int SaveSubscription(SubscriptionRequest request);
    }
}
