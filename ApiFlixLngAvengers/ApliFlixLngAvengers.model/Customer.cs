﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiFlixLngAvengers.model
{
    public class Customer  
    {   public int Id { get; set; } 
        public string FirstName { get; set; }    
        public string LastName { get; set; }  

        public int MobNum { get; set; }

        public string Email { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

       
    }
    public class Subscription   
    {   public int Id { get; set; }  
        public string Name { get; set; } 
    }
}