using Sistema_gestao.Context;
using Sistema_gestao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace Sistema_gestao.Controllers
{
    public class ProdutosController : Controller
    {
        private LojaContext db = new LojaContext();
        // GET: Produtos
        public ActionResult Index()
        {
            return View(db.produtos.OrderBy(x=>x.Descricao).ToList());
        }

        // GET: Produtos/Details/5
        public ActionResult Detalhes(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var produto = db.produtos.Find(id);
            if (produto == null)
            {
                return HttpNotFound();
            }
            return View(produto);
        }

        // GET: Produtos/Create
        public ActionResult Criar()
        {
            return View();
        }

        // POST: Produtos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Criar(Produtos produto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.produtos.Add(produto);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(produto);
            }
            catch
            {
                return View(produto);
            }
        }

        // GET: Produtos/Edit/5
        public ActionResult Editar(int id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var produto = db.produtos.Find(id);
            if (produto == null)
            {
                return HttpNotFound();
            }
            return View(produto);
        }

        // POST: Produtos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(Produtos produto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(produto).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");   
                }
                else {
                    return View(produto);
                }
            }
            catch
            {
                return View(produto);
            }
        }

        // GET: Produtos/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var produto = db.produtos.Find(id);
            if (produto == null)
            {
                return HttpNotFound();
            }
            return View(produto);
        }

        // POST: Produtos/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Produtos produto)
        {
            var prod = db.produtos.Find(id);
            try
            {
                db.Entry(prod).State = EntityState.Deleted;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(prod);
            }
        }
    }
}
