using SIA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Security.Cryptography;
using System.Text;

namespace SIA.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            /*
             * Aqui entraremos en una pequeña logica evaluando el tipo
             * de usuario que ingrese al sistema, por ejemplo si el 
             * usuario es un personal del área de carga deberá redireccionarse 
             * al controlador de Carga de lo contrario deberá ser dirigido
             * al controlador correspondiente siguiendo la instruccion:
             */

            return RedirectToAction("ReportesDeVenta", "Ventas");
        }

        public ActionResult Login() 
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Usuario u)
        {

            if (!ModelState.IsValid)
                return View("Login");

            try
            {
                using (IngresosEntities db = new IngresosEntities())
                {

                    var Hash = Encrypt.GetMD5(u.UserPass);
                    var obj = db.Usuario.Where(uModel => uModel.IdUsuario.Equals(u.IdUsuario) && uModel.UserPass == Hash).FirstOrDefault();


                    if (obj == null)
                    {
                        u.MensajeError = "Credenciales no validas";
                        return View("Login", u);
                    }
                    else
                    {
                        Session["IdUsuario"] = obj.IdUsuario.ToString();
                        Session["UserNom"] = obj.UserNom.ToString();
                        Session["UserApe"] = obj.UserApe.ToString();
                        Session["UserCar"] = obj.UserCar.ToString();

                        return RedirectToAction("Index");
                        
                    }

                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error al agregar al alumno", ex);
                return View();
            }

        }

        public ActionResult LogOut()
        {
            Session.Abandon();
            return RedirectToAction("Login");
        }
    }
}

public class Encrypt
{

    public static string GetMD5(string str)
    {

        MD5 md5 = MD5CryptoServiceProvider.Create();
        ASCIIEncoding encoding = new ASCIIEncoding();
        byte[] stream = null;
        StringBuilder sb = new StringBuilder();
        stream = md5.ComputeHash(encoding.GetBytes(str));
        for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
        return sb.ToString();
    }


}