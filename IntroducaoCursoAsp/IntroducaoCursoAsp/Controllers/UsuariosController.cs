using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IntroducaoCursoAsp.Models;

namespace IntroducaoCursoAsp.Controllers
{
    public class UsuariosController : Controller
    {
        // GET: Usuarios
        public ActionResult Usuario()
        {
            Usuarios usuario = new Usuarios();
            return View(usuario);
        }
        [HttpPost]
        public ActionResult Usuario(Usuarios usuario)
        {
            /*if (string.IsNullOrEmpty(usuario.Nome))
            {
                ModelState.AddModelError("Nome", "O campo nome é obrigatório");
            }
            if (usuario.Senha!=usuario.ConfirmaSenha)
            {
                ModelState.AddModelError("", "As senhas são diferentes!");
            }*/
            if (ModelState.IsValid)
            {
                return View("Resultado", usuario);
            }
            return View(usuario);
        }

        public ActionResult Resultado(Usuarios usuario)
        {
            return View(usuario);
        }

        public ActionResult LoginUnico(string login)
        {
            Collection<string> bdexemplo = new Collection<string>();
            bdexemplo.Add("lucas");
            bdexemplo.Add("hugo");
            bdexemplo.Add("paloma");

            return Json(bdexemplo.All(x => x.ToLower() != login.ToLower()), JsonRequestBehavior.AllowGet);
        }

    }
}