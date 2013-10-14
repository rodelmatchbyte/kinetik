using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace KinetikV1.Domain.Models
{
    public class Offer
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { set; get; }
        public string ImageUrl { set; get; }
        public string OfferType { get; set; }
        public string OfferDetail { get; set; }
        public string Stores { get; set; }
        public string Text { get; set; }
        public string Demog { get; set; }
        public string Method { get; set; }
        public long AccountId { get; set; }
    }
}