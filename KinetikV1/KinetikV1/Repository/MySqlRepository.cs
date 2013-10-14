using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KinetikV1.Domain.Interfaces;
using KinetikV1.Domain.Models;
using KinetikV1.Domain.Services;
using KinetikV1.Tools;

namespace KinetikV1.Repository
{
    public partial class MySqlRepository:IRepository
    {

        private readonly ILogger _logger = null;

        public MySqlRepository()
        {
            _logger = new MySqlLogger();
        }

        public List<Offer> Offer()
        {

            return EF.Execute("MySqlRepository.Offer[GET]",
                       ctx =>
                       {
                           var offers = from o in ctx.offers
                                        orderby o.id descending
                                        select new Offer()
                                        {
                                            Id = o.id,
                                            Title = o.title,
                                            Start = o.start.Value,
                                            End = o.end.Value,
                                            ImageUrl = o.imageUrl,
                                            OfferType = o.offerType,
                                            OfferDetail = o.offerDetail,
                                            Demog = o.demog,
                                            Method = o.method,
                                            Stores = o.stores,
                                            Text = o.text,
                                            AccountId = o.accountId
                                        };
                           return offers.ToList();

                       }, null);

        }

        public Offer Offer(int id)
        {
            return EF.Execute("MySqlRepository.Offer[GET](id)", 
                        ctx =>
                        {
                            var offer = (from o in ctx.offers
                                         where o.id == id
                                         select new Offer()
                                         {
                                             Id = o.id,
                                             Title = o.title,
                                             Start = o.start.Value,
                                             End = o.end.Value,
                                             ImageUrl = o.imageUrl,
                                             OfferType = o.offerType,
                                             OfferDetail = o.offerDetail,
                                             Demog = o.demog,
                                             Method = o.method,
                                             Stores = o.stores,
                                             Text = o.text,
                                             AccountId = o.accountId
                                         }).ToList();

                            // so we don't have to handle an exception, just return null
                            return offer.Count == 1 ? offer[0] : null;

                        }, null);
        }

        public void UpdateOffer(Offer offer)
        {
            EF.Execute("MySqlRepository.UpdateOffer", 
                ctx =>
                    {
                        var found = ctx.offers.First(o => o.id == offer.Id);
                        {
                            found.start = offer.Start;
                            found.end = offer.End;
                            found.imageUrl = offer.ImageUrl;
                            found.title = offer.Title;
                            found.method = offer.Method;
                            found.offerType = offer.OfferType;
                            found.stores = offer.Stores;
                            found.demog = offer.Demog;
                            found.text = offer.Text;
                            found.offerDetail = offer.OfferDetail;
                            found.accountId = offer.AccountId;
                            ctx.SaveChanges();
                            return offer;
                        }                       
                    }, null);

        }

        public void AddOffer(Offer offer)
        {
            EF.Execute("MySqlRepository.AddOffer", 
                ctx =>
                    {
                        ctx.offers.AddObject(new offer()
                        {
                            start = offer.Start,
                            end = offer.End,
                            title = offer.Title,
                            imageUrl = offer.ImageUrl,
                            method = offer.Method,
                            offerType = offer.OfferType,
                            offerDetail = offer.OfferDetail,
                            stores = offer.Stores,
                            demog = offer.Demog,
                            text = offer.Text,
                            date = DateTime.UtcNow,
                            accountId = offer.AccountId
                        });
                        ctx.SaveChanges();
                        return offer; 

                    }, null);

        }

        public void DeleteOffer(int id)
        {

            EF.Execute("MySqlRepository.DeleteOffer", 
                ctx =>
                    {
                        var found = ctx.offers.FirstOrDefault(o => o.id == id);
                        {
                            ctx.DeleteObject(found);
                            ctx.SaveChanges();
                        }

                        return id;
                    }, null);

        }

    }
}