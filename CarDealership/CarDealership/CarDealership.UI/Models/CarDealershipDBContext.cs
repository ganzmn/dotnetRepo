﻿using CarDealership.UI.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.UI
{
    public class CarDealershipDBContext : IdentityDbContext<AppUser>
    {
        public CarDealershipDBContext() : base("CarDealership")
        {

        }
    }
}
