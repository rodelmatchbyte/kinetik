using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using KinetikV1.Domain.Interfaces;
using KinetikV1.Domain.Extensions;
using KinetikV1.Domain.Services;
using KinetikV1.Repository;
using System.Web;
using KinetikV1.Tools;
using System.Security.Cryptography;
using KinetikV1.Domain.Models;

namespace KinetikV1.Controllers
{
    public class LoginController : ApiController
    {
        private readonly IRepository _repository;
        private readonly ILogger _logger;

        public LoginController()
        {
            _repository = new MySqlRepository();
            _logger = new MySqlLogger();
        }

        private string RegisterSession(Account account)
        {
            if(_repository.GetSession(account) != null) 
                _repository.DeleteSession(account);

            return _repository.RegisterSession(account);
        }

        // POST api/login
        public HttpResponseMessage Post()
        {
            try
            {
                var form = HttpContext.Current.Request.Form;
                var username = form["username"];
                var password = form["password"];

                var accounts = _repository.GetAccountsByName(username);
                if(accounts == null)
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Invalid username or password");

                if( ! string.IsNullOrEmpty(password))
                    password = Crypto.Encrypt<AesManaged>(
                        password, 
                        Setting.Value["cryptoPass"], 
                        Setting.Value["cryptoSalt"]);

                var account = accounts.Find(a => a.Password == password);

                if(account == null)
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Invalid username or password");

                var hash = RegisterSession(account);
                return Request.CreateResponse(HttpStatusCode.OK,
                    new
                        {
                          Hash = hash,
                          Id = account.Id,
                          Name = account.Name,
                          Logo = account.Logo
                        });
            }

            catch(Exception ex)
            {
                _logger.Log("LoginController.Post", ex);
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

    }
}
