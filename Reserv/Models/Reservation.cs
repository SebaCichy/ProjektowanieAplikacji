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
        public int CarID { get; set; }
        public int UserID { get; set; }
        [Key]
        public int? ReservationID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual Cars Cars { get; set; }
        public virtual Users Users { get; set; }
        [NotMapped]
        public List<Cars> CarsCollections { get; set; }

    }
}