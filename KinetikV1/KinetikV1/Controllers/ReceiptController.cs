using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using KinetikV1.Domain.Interfaces;
using KinetikV1.Repository;
using KinetikV1.Tools;

namespace KinetikV1.Controllers
{
    public class ReceiptController : ApiController
    {
        private readonly IRepository _repository = null;

        public ReceiptController()
        {
            _repository = new MySqlRepository();
        }

        public HttpResponseMessage Get()
        {
            var transactions = _repository.GetShopifyTransactions();

            switch(Request.RequestUri.Segments.Length)
            {
                case 4:
                    {
                        var r = new List<string>();
                        transactions.ForEach( t => r.Add(ValueFromJson.Get(t, "receiptNo")));
                        return Request.CreateResponse(HttpStatusCode.OK, r);
                    }
                case 5:
                    {
                        var c = transactions.Count();
                        var t = string.Empty;
                        for (var i = 0; i < c; i++)
                        {
                            t = transactions[i];
                            if (ValueFromJson.Get(t, "receiptNo") == Request.RequestUri.Segments[4])
                            {
                                return Request.CreateResponse(HttpStatusCode.OK,
                                                              new
                                                              {
                                                                  receiptNo = ValueFromJson.Get(t, "receiptNo"),
                                                                  transactionDate = ValueFromJson.Get(t, "transactionDate"),
                                                                  storeName = ValueFromJson.Get(t, "storeName"),
                                                                  creditCard = ValueFromJson.Get(t, "creditCard"),
                                                                  grandTotal = ValueFromJson.Get(t, "grandTotal")
                                                              });
                            }
                        }
                        break;
                    }
            }
            return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Please contact server administrator.");
        }

        /*****
        public List<string> Get()
        {
            var transactions = _repository.GetShopifyTransactions();
            var receipts = new List<string>();
            transactions.ForEach( s => receipts.Add(ValueFromJson.Get(s, "receiptNo")));
            return receipts;
        }


        [HttpGet]
        public  HttpResponseMessage GetReceipt(string receipt)
        {
            var transactions = _repository.GetShopifyTransactions();

            var data = new List<Tuple<string, string, string, string, string>>();
            var c = transactions.Count();
            var t = string.Empty;
            for (var i = 0; i < c; i++)
            {
                t = transactions[i];
                if(ValueFromJson.Get(t, "receiptNo") == receipt)
                {
                    return Request.CreateResponse(HttpStatusCode.OK,
                                                  new
                                                      {
                                                          receiptNo = ValueFromJson.Get(t, "receiptNo"),
                                                          transactionDate = ValueFromJson.Get(t, "transactionDate"),
                                                          storeName = ValueFromJson.Get(t, "storeName"),
                                                          creditCard = ValueFromJson.Get(t, "creditCard"),
                                                          grandTotal = ValueFromJson.Get(t, "grandTotal")
                                                      });
                }
            }

            return Request.CreateErrorResponse(HttpStatusCode.NoContent, "Please contact server admin.");

        }
        *****/

    }
}
