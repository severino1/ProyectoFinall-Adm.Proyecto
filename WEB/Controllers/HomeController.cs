using WEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.Mvc;
using System.Globalization;

namespace WEB.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Home()
        {
            return View();
        }
        public ActionResult Inicio()
        {
            return View();
        }
       
        //aqui esla secion para las vistas de detalle de los programas
        public ActionResult Dbanco()
        {
            return View();
        }
        public ActionResult Dcolegio()
        {
            return View();
        }
        public ActionResult Dcon()
        {
            return View();
        }
        public ActionResult Dvmax()
        {
            return View();
        }
        //aqui esla secion para las vistas de detalle de los programas
        public ActionResult Web()
        {
            return View();
        }
        public ActionResult Programas()
        {
            return View();
        }
        public ActionResult aplicaciones()
        {
            return View();
        }
        public ActionResult soporte()
        {
            return View();
        }

        public ActionResult Nosotros()
        {
            return View();
        }
        //[Authorize]
        public ActionResult Productos()
        {
            return View();
        }
        //cursos que ofresemos

        public ActionResult cursoW()
        {
            return View();
        }

        public ActionResult cursoP()
        {
            return View();
        }
        public ActionResult Dodontologia()
        {
            return View();
        }
        public ActionResult Drenta()
        {
            return View();
        }
       
        // GET: Index
        [HttpGet]
        public ActionResult login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult login(Usuario user)
        {
            datosbdcontex db = new datosbdcontex();
            Usuario logueado = db.Usuarios.Where(u => u.Correo == user.Correo & u.Contraseña == user.Contraseña).FirstOrDefault();
            if (logueado != null)
            {
                FormsAuthentication.SetAuthCookie(user.Correo, true);
                return RedirectToAction("Productos", "Home");
            }
            ViewBag.mensaje = "Usuario Incorrecto o Contraseña Incorrectos";
            return View(user);
        }
        [HttpGet]
        public ActionResult Logoff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Home", "Home");
        }
    }
}
      







