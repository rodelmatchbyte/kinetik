using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KinetikV1.Tools;

namespace KinetikV1.Repository
{
    public partial class MySqlRepository
    {
        public void AddShopifyTransaction(string json)
        {
            EF.Execute("MySqlRepository.AddShopifyTransaction",
                ctx =>
                {
                    ctx.commerces.AddObject(new commerce()
                    {
                        //fulfillmentStatus = ValueFromJson.Get(json, "fulfillment_status"),
                        //checkoutId = ValueFromJson.Get(json, "checkout_id"),
                        detail = json,
                        //detail = detail,
                        date = DateTime.UtcNow
                    });

                    ctx.SaveChanges();
                    return true;
                }, () => false);

        }

        public string GetShopifyTransaction(string checkoutId)
        {

            return EF.Execute("MySqlRepository.GetShopifyTransaction",
                ctx =>
                {
                    var commerce = ctx.commerces.Where(c => c.checkoutId == checkoutId).ToList();
                    return commerce.Count > 0 ? commerce[0].detail : string.Empty;
                }, null);
        }

        public List<string> GetShopifyTransactions()
        {
            return EF.Execute("MySqlRepository.GetShopifyTransactions",
                ctx =>
                {
                    var details = new List<string>();
                    ctx.commerces.ToList().ForEach(c => details.Add(c.detail));
                    return details;
                }, null);
        }
    }
}