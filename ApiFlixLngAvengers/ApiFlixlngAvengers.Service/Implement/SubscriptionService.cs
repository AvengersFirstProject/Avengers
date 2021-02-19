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
            if (request.SubscriptionType == subtype.HalfYearly)
            {
                currentdate = DateTime.Now;
                expiryDate = DateTime.Now.AddMonths(6);
            }
            else if
                (request.SubscriptionType == subtype.Quaterly)
            {
                currentdate = DateTime.Now;
                expiryDate = DateTime.Now.AddMonths(3);
            }
            else if
                (request.SubscriptionType == subtype.Yearly)
            {
                currentdate = DateTime.Now;
                expiryDate = DateTime.Now.AddMonths(12);
            }

            Subscription Subscriptionobj = new Subscription();
            Subscriptionobj.StartDate = DateTime.Now;
            Subscriptionobj.EndDate = expiryDate;
            Subscriptionobj.SubscriptionType = request.SubscriptionType;


            _avengersDbContext.Subscription.Add(Subscriptionobj);


            _avengersDbContext.SaveChanges();

            return Subscriptionobj.Id;




        }
        
    }
}
