﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using TeamLID.TravelExperts.Repository.Domain;

namespace TeamLID.TravelExperts.App.Models
{
    public class BookingsModel
    {
        public int BookingId { get; set; }

        [DataType(DataType.Date), DisplayName("Booking Date")]
        public DateTime? BookingDate { get; set; }

        [DisplayName("Booking Number")]
        public string BookingNo { get; set; }

        [DisplayName("Number of Travellers")]
        public double? TravelerCount { get; set; }

        [DisplayName("Customer")]
        public string CustomerId { get; set; }

        [DisplayName("Trip Type")]
        public string TripTypeId { get; set; }

        public ICollection<BookingDetails> BookingDetails { get; set; }


    }
}
