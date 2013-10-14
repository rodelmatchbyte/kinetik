using System;
using System.Collections.Generic;
using System.Linq;
using KinetikV1.Domain.Models;
using KinetikV1.Tools;
using System.Security.Cryptography;
using KinetikV1.Domain.Services;

namespace KinetikV1.Repository
{
    public partial class MySqlRepository
    {
        public void AddAccount(Account account)
        {

            EF.Execute("MySqlRepository.AddAccount",
                ctx =>
                    {
                        ctx.accounts.AddObject(new account
                                                   {
                                                       name = account.Name,
                                                       email = account.Email,
                                                       category = account.Category,
                                                       logo = account.Logo,
                                                       password = Crypto.Encrypt<AesManaged>(
                                                            account.Password, 
                                                            Setting.Value["cryptoPass"], 
                                                            Setting.Value["cryptoSalt"]),
                                                       status = "Active",
                                                       created = DateTime.UtcNow
                                                   });
                        ctx.SaveChanges();
                        return account;
                    }, null);
        }

        public void DeleteAccount(long id)
        {
            EF.Execute("MySqlRepository.DeleteAccount",
                ctx =>
                    {
                        var found = ctx.accounts.First(a => a.id == id);
                        {   
                            ctx.DeleteObject(found);
                            ctx.SaveChanges();
                            return true;
                        }
                    },
                    () => false);
        }


        public void UpdateAccount(Account account)
        {
            EF.Execute("MySqlRepository.UpdateAccount",
                ctx =>
                    {
                        var found = ctx.accounts.First(a => a.id == account.Id);
                        {
                            found.name = account.Name;
                            found.email = account.Email;
                            found.category = account.Category;

                            if( ! string.IsNullOrEmpty(account.Logo) && found.logo != account.Logo)
                            found.logo = account.Logo;

                            if(! string.IsNullOrEmpty(account.Password) &&  found.password != account.Password)
                                found.password = Crypto.Encrypt<AesManaged>(
                                    account.Password, 
                                    Setting.Value["cryptoPass"], 
                                    Setting.Value["cryptoSalt"]);
                        }

                        ctx.SaveChanges();
                        return account;

                    }, null);
        }

        public List<Account> GetAccounts()
        {

            return EF.Execute("MySqlRepository.GetAccounts",
                    ctx =>
                        {
                            var accounts = from a in ctx.accounts
                                           select new Account
                                                      {
                                                          Id = a.id,
                                                          Name = a.name,
                                                          Email = a.email,
                                                          Category = a.category,
                                                          Logo = a.logo,
                                                          Password = a.password,
                                                          Created = a.created,
                                                          Status = a.status 
                                                      };

                            return accounts.ToList();
                        }, null);
        }

        public List<Account> GetAccountsByName(string name)
        {
            return EF.Execute("MySqlRepository.GetAccountsByName",
                ctx =>
                    {
                        var accounts = from a in ctx.accounts
                                       where a.name == name
                                       select new Account()
                                                  {
                                                      Id = a.id,
                                                      Name = a.name,
                                                      Email = a.email,
                                                      Category = a.category,
                                                      Logo = a.logo,
                                                      Password = a.password,
                                                      Created = a.created,
                                                      Status = a.status 
                                                  };
                        return accounts.ToList();
                    }, null);
        }

        public Account GetAccount(long id)
        {
            return EF.Execute("MySqlRepository.GetAccount",
                ctx =>
                    {
                        var found = ctx.accounts.First(a => a.id == id);
                        return new Account
                                   {
                                       Id = found.id,
                                       Name = found.name,
                                       Email = found.email,
                                       Category = found.category,
                                       Logo = found.logo,
                                       Password = found.password,
                                       Created =  found.created,
                                       Status = found.status
                                   };
                    },
                    null);
        }
    }
}