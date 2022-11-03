using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace TeamLID.TravelExperts.Repository.Domain
{
    public partial class Bookings
    {
        public Bookings()
        {
            BookingDetails = new HashSet<BookingDetails>();
        }

        public int BookingId { get; set; }
        [DisplayName("Booking Date")]
        public DateTime? BookingDate { get; set; }
        public string BookingNo { get; set; }
        [DisplayName("Travellers No")]
        public double? TravelerCount { get; set; }
        [DisplayName("Customer Place")]
        public int? CustomerId { get; set; }
        [DisplayName("Trip Type")]
        public string TripTypeId { get; set; }
        [DisplayName("Package Name")]
        public int? PackageId { get; set; }

        public virtual Customers Customer { get; set; }
        public virtual Packages Package { get; set; }
        public virtual TripTypes TripType { get; set; }
        public virtual ICollection<BookingDetails> BookingDetails { get; set; }

    }
}
