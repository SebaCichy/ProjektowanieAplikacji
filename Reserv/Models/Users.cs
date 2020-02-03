using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Reserv.Models
{
    [Table("Student")]
    public class Users
    {
        [Key]
        public int  UserID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}