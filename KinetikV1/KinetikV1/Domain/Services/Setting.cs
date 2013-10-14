using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KinetikV1.Repository;
using KinetikV1.Tools;
using KinetikV1.Domain.Interfaces;

namespace KinetikV1.Domain.Services
{
    public class Setting
    {
        public static Setting Value = new Setting();
        private readonly IRepository _repository = new MySqlRepository();

        public string this[string key]
        {
            get
            {
                return _repository.GetSettingValue(key);

            }

            set
            {
                _repository.SetSettingValue(key, value);

            }

        }
    }
}