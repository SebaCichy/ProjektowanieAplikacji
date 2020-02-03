using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Reserv.Models
{
    [Table("Cars")]
    public class Cars
    {
        [Key]
        public int CarID { get; set; }
        public string RegistrationNumber { get; set; } 
        public string Brand { get; set; }
        public string Model { get; set; }
        public bool Available { get; set; }
    }
}