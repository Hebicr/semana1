using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace semana1.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login(String usuario,string password)
        {
            try {
                return Content("1");

            } catch (Exception ex) {
                return Content("Ocurrio un error : "+ ex.Message);
            }
        }
    }
}