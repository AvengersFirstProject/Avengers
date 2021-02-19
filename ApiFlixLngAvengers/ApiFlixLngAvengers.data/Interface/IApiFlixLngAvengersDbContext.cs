using ApiFlixLngAvengers.model;
using ApliFlixLngAvengers.model.Models;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiFlixLngAvengers.data.Interface
{
    public interface IApiFlixLngAvengersDbContext : IDisposable, IDbContext
    {
        DbSet<Customer> Customer { get; set; }
        DbSet<Subscription> Subscription { get; set; }
    }
}
