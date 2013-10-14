using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace KinetikV1.Domain.Models
{
    public class Account
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Category { get; set; }
        public string Logo { get; set; }
        public string Password { get; set; }
        public DateTime? Created { get; set; }
        public string Status { get; set; }
    }
}