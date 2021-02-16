using ApiFlixLngAvengers.data.Interface;
using ApiFlixLngAvengers.model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace ApiFlixLngAvengers.data
{
     public class ApiFlixLngAvengersDbContext :DbContext, IApiFlixLngAvengersDbContext
    {
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Subscription> Subscription { get; set; }
        
        public ApiFlixLngAvengersDbContext(DbContextOptions<ApiFlixLngAvengersDbContext> options) : base(options)
        {
        }

       
    }
}
