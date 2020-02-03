using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Reserv.Models
{
    [Table("Reservations")]
    public class Reservation
    {
        [Key]
        public int ReservationID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [ForeignKey("Car")]
        public int CarID { get; set; }
        public virtual Cars Car { get; set; }
        [ForeignKey("User")]
        public string UserID { get; set; }
        public virtual ApplicationUser User { get; set; }
        [NotMapped]
        public List<Cars> CarsCollections { get; set; }

    }
}