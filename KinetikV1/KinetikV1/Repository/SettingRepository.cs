using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KinetikV1.Tools;

namespace KinetikV1.Repository
{
    public partial class MySqlRepository
    {
        public string GetSettingValue(string key)
        {
            return EF.Execute("Setting.Get",
            ctx =>
                {
                    var found = ctx.settings.First(s => s.key == key);
                    return found != null ? found.value : null;
                }, null);

        }

        public void SetSettingValue(string key, string value)
        {
            EF.Execute<string>("Setting.Set",
            ctx =>
            {
                var found = ctx.settings.First(s => s.key == key);
                if (found != null)
                {
                    found.value = value;
                }
                else
                {
                    ctx.settings.AddObject(
                        new setting()
                        {
                            key = key,
                            value = value
                        });
                }

                ctx.SaveChanges();
                return value;

            }, null);
        }
    }
}