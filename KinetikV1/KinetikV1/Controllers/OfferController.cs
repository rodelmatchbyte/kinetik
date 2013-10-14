using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using KinetikV1.Domain.Models;
using KinetikV1.Domain.Interfaces;
using KinetikV1.Domain.Services;
using KinetikV1.Repository;
using KinetikV1.Domain.Extensions;
using System.Web;
using KinetikV1.Tools;


namespace KinetikV1.Controllers
{
    public class OfferController : ApiController
    {

        private readonly IRepository _repository = null;
        private readonly ILogger _logger = null;

        public OfferController()
        {
            _repository = new MySqlRepository();
            _logger = new MySqlLogger();
        }

        public List<Offer> Get()
        {
            return _repository.Offer().ToList();
        }

        public Offer Get(int id)
        {
            var offer = _repository.Offer(id);
            return offer?? new Offer(){Id = -1};
        }

        private void ResizeImage(string filename)
        {
            var file = HttpContext.Current.Server.MapPath("~/../UploadedImages/" + filename);
            const int width = 50;
            const int height = 50;
            ImageResizer.ResizeImage(file, file, width, height, true);
        }

        private string UploadFile(HttpRequest request)
        {

            if (request.Files.Count == 0) return string.Empty;
            var filename = "";
            foreach (string file in request.Files)
            {
                var postedFile = request.Files[file];
                if (string.IsNullOrEmpty(postedFile.FileName)) continue;
                var filePath = HttpContext.Current.Server.MapPath("~/../UploadedImages/" + postedFile.FileName); 
                postedFile.SaveAs(filePath);
                filename = postedFile.FileName;
            }
            return filename;
        }

        private DateTime GetDate(string str)
        {
            if (string.IsNullOrEmpty(str)) return DateTime.MinValue;
            return new DateTime(int.Parse(str.Substring(6)), //year 
                                int.Parse(str.Substring(0, 2)), //month
                                int.Parse(str.Substring(3, 2))); //day
        }


        private Offer GetOffer(HttpRequest request, string filename)
        {
            var form = request.Form;
            var offerType = form["offer_name"];
            return new Offer()
                       {
                           Title = form["title"],
                           Start = GetDate(form["start"]),
                           End = GetDate(form["end"]),
                           OfferType = offerType,
                           OfferDetail = offerType == "1" ? form["percentage"] : offerType == "2" ? form["cashback"] : form["buyx"],
                           Demog = form["target_aud"],
                           Method = form["redemp_method"],
                           Stores = form["stores"],
                           Text = form["offer_detail"],
                           ImageUrl = filename,
                           AccountId = int.Parse(form["account_id"])
                       };
        }

        public void Post()
        {
            try
            {
                var httpRequest = HttpContext.Current.Request;
                var filename = UploadFile(httpRequest);
                if( ! string.IsNullOrEmpty(filename)) ResizeImage(filename);
                var offer = GetOffer(httpRequest, filename);
                _repository.AddOffer(offer);

            }

            catch(Exception ex)
            {
                _logger.Log("OfferController.Post", ex.InnerException != null ? ex.InnerException.Message : ex.Message);
            }
        }

        public HttpResponseMessage Put(Offer offer)
        {
            try
            {
                //_logger.Log("OfferController.Put", offer.Stringify());
                _repository.UpdateOffer(offer);
                return Request.CreateResponse(HttpStatusCode.OK, offer);
            }

            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }

        }

        public HttpResponseMessage Delete(int id)
        {
            try
            {
                _repository.DeleteOffer(id);
                return Request.CreateResponse(HttpStatusCode.OK, id);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
            
        }

    }
}
