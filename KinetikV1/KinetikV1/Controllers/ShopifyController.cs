using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using KinetikV1.Domain.Interfaces;
using KinetikV1.Domain.Services;
using System.Net.Http;
using System.IO;
using System.Threading;
using System.Text;
using KinetikV1.Repository;

namespace KinetikV1.Controllers
{
    public class ShopifyController: ApiController
    {
        private readonly IRepository _repository = null;
        public ShopifyController()
        {
            _repository = new MySqlRepository();
        }

        private void ProcessRequest()
        {
            var body = Request.Content.ReadAsStringAsync().Result.Substring(5);
            _repository.AddShopifyTransaction(body);
        }

        public HttpResponseMessage Post()
        {
            ProcessRequest();
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        public string Get(string id)
        {
            return _repository.GetShopifyTransaction(id);
        }

        public List<string> Get()
        {
            return _repository.GetShopifyTransactions();
        }
    }
}