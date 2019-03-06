using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IntroducaoCursoAsp.Models;

namespace IntroducaoCursoAsp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Pessoas pessoa = new Pessoas();
            pessoa.PessoaId = 1;
            pessoa.Nome = "lucas";
            pessoa.Tipo = "admin";

           /* ViewData["PessoaId"] = pessoa.PessoaId;
            ViewData["Nome"] = pessoa.Nome;
            ViewData["Tipo"] = pessoa.Tipo;
            ViewBag.Id = pessoa.PessoaId;
            ViewBag.Nome = pessoa.Nome;
            ViewBag.Tipo = pessoa.Tipo;
            */
            return View(pessoa);
        }

        public ActionResult Contatos()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Lista(Pessoas pessoa)
        {
            //
            //FormCollection form
            /* ViewData["PessoaId"] = form["PessoaId"];
             ViewData["Nome"] = form["Nome"];
             ViewData["Tipo"] = form["Tipo"];*/

            return View(pessoa);
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
    }
}