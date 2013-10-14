using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KinetikV1.Domain.Models;
using KinetikV1.Tools;
using KinetikV1.Domain.Extensions;

namespace KinetikV1.Repository
{
    public partial class MySqlRepository
    {
        public string RegisterSession(Account account)
        {
            return EF.Execute("MySqlRepository.RegisterSession", 
                ctx =>
                    {
                        var hash = account.Hash();
                        ctx.sessions.AddObject(new session()
                                                   {
                                                       accountId = account.Id,
                                                       date = DateTime.UtcNow,
                                                       hash = hash
                                                   });
                        ctx.SaveChanges();
                        return hash;
                    }, null);
        }

        public void DeleteSession(Account account)
        {
            EF.Execute("MySqlRepository.DeleteSession", 
                ctx=>
                    {
                        var sessions = from s in ctx.sessions
                                       where s.accountId == account.Id
                                       select s;

                        foreach (var s in sessions)
                        {
                            ctx.DeleteObject(s);
                        }

                        ctx.SaveChanges();
                        return account;

                    }, null);
        }

        public string GetSession(Account account)
        {
            return EF.Execute("MySqlRepository.VerifySession", 
                ctx =>
                    {
                        var sessions = (from s in ctx.sessions
                                       where s.accountId == account.Id
                                       select s.hash).ToList();

                        return sessions.Count == 0 ? null : sessions[0];

                    }, null);
        }
    }
}