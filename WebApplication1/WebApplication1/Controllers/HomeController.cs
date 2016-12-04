using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DepartmentModel model = DepartmentModel.TmpData(); 
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult About(UserModel model)
        {
            if (ModelState.IsValid)
            {
                if (FormsAuthentication.Authenticate(model.Login, model.Password)) //может быть поиск в базе
                {
                    FormsAuthentication.SetAuthCookie(model.Login, false);
                    return View(model);
                }
                else
                {
                    model = new UserModel();
                }
            }
            return View(model);
        }
        
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}