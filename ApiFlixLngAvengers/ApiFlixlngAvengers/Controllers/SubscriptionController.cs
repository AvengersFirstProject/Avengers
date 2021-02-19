using ApiFlixLngAvengers.data.Interface;
using ApiFlixLngAvengers.Service.Interface;
using ApliFlixLngAvengers.model.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ApiFlixlngAvengers.Controllers
{
    [ApiController]

    [Route("[controller]")]
    public class SubscriptionController : Controller
    {
        private readonly IApiFlixLngAvengersDbContext _avengersDbContext;

        private readonly ISubscriptionService _subscriptionservice;
        public SubscriptionController(IApiFlixLngAvengersDbContext avengersDbContext, ISubscriptionService subscriptionservice)
        {
            _avengersDbContext = avengersDbContext;

            _subscriptionservice = subscriptionservice;

        }
        [HttpPost]
        [Route("SaveSubscription")]
        public ActionResult<SubscriptionResponse> Save(SubscriptionRequest request)
        {
            int SubscriptionId = _subscriptionservice.SaveSubscription(request);

            return StatusCode((int)HttpStatusCode.OK,
                new SubscriptionResponse { Id = SubscriptionId });
        }
    }
}
