using ApiFlixLngAvengers.data.Interface;
using ApiFlixLngAvengers.Service.Interface;
using ApliFlixLngAvengers.model.Models;
using ApliFlixLngAvengers.model.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiFlixLngAvengers.Service.Implement
{
     public class SubscriptionService : ISubscriptionService

    {

        DateTime currentdate;
        DateTime expiryDate;
        private readonly IApiFlixLngAvengersDbContext _avengersDbContext;

        public SubscriptionService(IApiFlixLngAvengersDbContext avengersDbContext)
        {
            _avengersDbContext = avengersDbContext;

        }

        public int SaveSubscription(SubscriptionRequest request)
         
        {
            Subscription Subscriptionobj = new Subscription()
            {
              SubscriptionType = request.SubscriptionType,
              StartDate = request.StartDate,
              EndDate = request.EndDate

            };
            _avengersDbContext.Subscription.Add(Subscriptionobj);


            _avengersDbContext.SaveChanges();

            return Subscriptionobj.Id;
        }
    }
}
