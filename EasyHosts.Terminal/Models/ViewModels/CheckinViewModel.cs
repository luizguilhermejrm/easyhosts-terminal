﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace EasyHosts.Terminal.Models.ViewModels
{
    public class CheckinViewModel
    {
        public int CheckinId { get; set; }

        [DisplayName("Reserva")]
        public int BookingId { get; set; }
        public Booking Booking{ get; set; }

        [DisplayName("Usuario")]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}