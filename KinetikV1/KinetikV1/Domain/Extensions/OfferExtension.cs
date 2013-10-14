using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KinetikV1.Domain.Models;
using System.Text;

namespace KinetikV1.Domain.Extensions
{
    public static class OfferExtension
    {
        public static string Stringify(this Offer offer)
        {
            var str = new StringBuilder();
            str.Append("Id:" + offer.Id);
            str.Append(" Title:" + offer.Title);
            str.Append(" Start:" + offer.Start.ToString("yyyy/mm/dd"));
            str.Append(" End:" + offer.End.ToString("yyyy/mm/dd"));
            str.Append(" ImgUrl:" + offer.ImageUrl);
            str.Append(" OfferType:" + offer.OfferType);
            str.Append(" OfferDetail:" + offer.OfferDetail);
            str.Append(" Stores:" + offer.Stores);
            str.Append(" Text:" + offer.Text);
            str.Append(" Demog:" + offer.Demog);
            str.Append(" Method:" + offer.Method);
            return str.ToString();
        }
    }
}