using DotNetOpenAuth.AspNet;
using openid.Controllers;
using openid.Models;
using System;
using System.IO;
using System.Net;
using System.Web.Mvc;

namespace openid.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Vk()
        {
            VkClientModel vkModel = new VkClientModel();

            vkModel.Code = Request["code"];
            string adsress = "https://oauth.vk.com/access_token?client_id=5780500&client_secret=FkANh5d3BxS3CccHKaHp&redirect_uri=https://localhost:44382/Home/Vk&code=" + vkModel.Code;
            string Response = new StreamReader(WebRequest.Create(adsress).GetResponse().GetResponseStream()).ReadToEnd();

            vkModel.Token = Response.Substring(Response.IndexOf("access_token") + 15, 85);
            vkModel.data.UserID = Response.Substring(Response.IndexOf("user_id") + 9, 8);
            vkModel.data.Email = Response.Substring(Response.IndexOf("email") + 8).Substring(0, Response.Substring(Response.IndexOf("email") + 8).IndexOf('\"'));
          
            AccountController acc = new AccountController();
            VkProvider provider = new VkProvider { Name = "Vkontakte", AppId = "5780500", AppSecret = "FkANh5d3BxS3CccHKaHp" };
            //acc.ExternalLogin(provider.Name, "~Home/About");
            //acc.ExternalLoginCallback("~Home/About");

            return View(vkModel);
        }
    }
}

