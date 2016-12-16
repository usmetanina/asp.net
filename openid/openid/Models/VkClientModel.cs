using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace openid.Models
{
    public class VkProvider
    {
        public string AppId { get; set; }
        public string AppSecret { get; set; }
        public string Name { get; set; }
    }

    public class VkClientModel
    {
        public string Code { get; set; }
        public string Token { get; set; }
        public DataAboutVkUser data = new DataAboutVkUser();
    }
    public class DataAboutVkUser
    {
        public string UserID { get; set; }
        public string Email { get; set; }
    }

    public class VkOptions : AuthenticationOptions
    {
        public VkOptions(string authenticationType) : base(authenticationType)
        {
        }

        public string AppId { get; set; }
        public string AppSecret { get; set; }
    }
}