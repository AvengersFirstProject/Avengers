using ApiFlixLngAvengers.model;
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
    }
}
