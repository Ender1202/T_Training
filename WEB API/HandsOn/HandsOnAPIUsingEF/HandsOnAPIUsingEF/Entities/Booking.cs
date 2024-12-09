using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HandsOnAPIUsingEF.Entities
{
    public class Booking
    {
        public string BookingId { get; set; }
        public DateTime BookingDate { get;set; }
        [ForeignKey("MovieNavigation")]
        public string MovieId { get; set; }
        [ForeignKey("UserNavigation")]
        public string UserId { get; set; }
        public Movie MovieNavigation { get; set; }
        public User UserNavigation { get; set; } 
    }
}