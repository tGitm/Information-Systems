using System;
using System.Collections.Generic;

namespace web.Models
{
    public class Reservation
    {
        public int TableID { get; set; }
        public int NumberOfGuests { get; set; }
        public DateTime DateOfReservation { get; set; }
    }
}