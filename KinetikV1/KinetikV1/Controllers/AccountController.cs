using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using KinetikV1.Domain.Models;
using KinetikV1.Domain.Interfaces;
using KinetikV1.Domain.Services;
using KinetikV1.Repository;
using System.Web;
using KinetikV1.Tools;

namespace KinetikV1.Controllers
{
    public class AccountController : ApiController
    {
        private readonly IRepository _repository;
        private readonly ILogger _logger;

        public AccountController()
        {
            _repository = new MySqlRepository();
            _logger = new MySqlLogger();
        }

        public List<Account> Get()
        {
            return _repository.GetAccounts();
        }

        public string GetLogoUrl(int id)
        {
            var account = _repository.GetAccount(id);
            return account == null ? string.Empty : account.Logo;
        }

        public HttpResponseMessage GetLogo(int id)
        {
            var account = _repository.GetAccount(id);
            if (account == null)
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, string.Format("{0} not found.", id));

            var response = new HttpResponseMessage(HttpStatusCode.OK);

            const string folder = "~/../logos/";
            var filePath = HttpContext.Current.Server.MapPath(folder + account.Logo);
            var stream = new System.IO.FileStream(filePath, System.IO.FileMode.Open);
            response.Content = new StreamContent(stream);
            response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");
            response.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment") 
            {FileName = string.Format("logo-{0}.png", id)};
            return response;


        }

        public Account Get(int id)
        {
            return _repository.GetAccount(id);
        }
       
        private Account GetAccount(HttpRequest request, string logo)
        {
            var form = request.Form;
            return new Account
                       {
                           Name = form["name"],
                           Email = form["email"],
                           Category = form["category"],
                           Logo = logo,
                           Password = form["password"],
                           Id = int.Parse(form["id"])
                       };
        }

        public HttpResponseMessage Post()
        {
            try
            {
                var httpRequest = HttpContext.Current.Request;
                var logoname = FileUploader.Upload(httpRequest, "~/../logos/");
                var account = GetAccount(httpRequest, logoname);

                if (account.Id == 0) _repository.AddAccount(account); 
                else _repository.UpdateAccount(account);

                return Request.CreateResponse(HttpStatusCode.OK, account);

            }
            catch(Exception ex)
            {
                _logger.Log("AccountController.Post", ex);
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        public void Put(Account account)
        {
            _repository.UpdateAccount(account);
        }


        public void Delete(int id)
        {
            _repository.DeleteAccount(id);
        }
    }
}
