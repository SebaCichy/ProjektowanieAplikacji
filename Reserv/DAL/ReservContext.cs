using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reserv.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Reserv.DAL
{
    public class ReservContext :DbContext
    {
        public ReservContext() : base("ReservContext")
        {
        }


        public DbSet<Users> Users { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Cars> Cars { get; set; }


    }
}