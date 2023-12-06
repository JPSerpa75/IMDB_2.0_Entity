using IMDB_2._0___Entity.Context;
using IMDB_2._0___Entity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace IMDB_2._0___Entity.Controllers
{
    public class AtorController : Controller
    {
        private EFContext context = new EFContext();

        public ActionResult Index()
        {
            return View(context.atores.OrderBy(c => c.nome));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Ator ator)
        {
            context.atores.Add(ator);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Ator ator = context.atores.Find(id);
            if (ator == null)
            {
                return HttpNotFound();
            }

            return View(ator);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Ator ator)
        {
            if (ModelState.IsValid)
            {
                context.Entry(ator).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ator);
        }

        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Ator ator = context.atores.Find(id);

            if (ator == null)
            {
                return HttpNotFound();
            }
            return View(ator);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long id)
        {
            Ator ator = context.atores.Find(id);
            if (ator.atuacoes.Count > 0)
            {
                ModelState.AddModelError(string.Empty, "O seguinte ator não pode ser excluído pois possui atuações associadas ele.");
                return View(ator);
            }
            context.atores.Remove(ator);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}