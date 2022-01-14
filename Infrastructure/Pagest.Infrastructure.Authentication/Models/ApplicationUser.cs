using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Pagest.Infrastructure.Authentication.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual string Fullname => this.LastName + ' ' + this.FirstName;
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsDelete { get; set; }
        public string ImageName{ get; set; }
    }
}
