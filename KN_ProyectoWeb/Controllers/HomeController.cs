using KN_ProyectoWeb.EF;
using KN_ProyectoWeb.Models;
using System.Web.Mvc;

namespace KN_ProyectoWeb.Controllers
{
    public class HomeController : Controller
    {
        #region Iniciar Sesión

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Usuario usuario)
        {
            /*Progra para ir a iniciar sesión en la BD*/

            return RedirectToAction("Principal", "Home");
        }
        #endregion

        #region Registro

        [HttpGet]
        public ActionResult Registro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registro(Usuario usuario)
        {
            using (var context = new BD_KNEntities())
            {
                var nuevoUsuario = new tbUsuario
                {
                    Identificacion = usuario.Identificacion,
                    Nombre = usuario.Nombre,
                    CorreoElectronico = usuario.CorreoElectronico,
                    Contrasenna = usuario.Contrasenna,
                    ConsecutivoPerfil = 2, 
                    Estado = true
                };
                context.tbUsuario.Add(nuevoUsuario);
                context.SaveChanges();

            } 
                return View();
        }
        #endregion

        #region Recuperar Contraseña

        [HttpGet]
        public ActionResult RecuperarAcceso()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RecuperarAcceso(Usuario usuario)
        {
            /*Validar si el usuario existe, generar una clave temporal, enviarle esa clave al usuario*/
            return View();
        }
        #endregion


        public ActionResult Principal()
        {
            return View();
        }

    }
}