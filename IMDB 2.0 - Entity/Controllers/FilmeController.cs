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
    public class FilmeController : Controller
    {
		private EFContext context = new EFContext();

		public ActionResult Index()
		{
			return View(context.Filmes.OrderBy(c => c.titulo));
		}

		public ActionResult Create()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(Filme filme)
		{
			context.Filmes.Add(filme);
			context.SaveChanges();
			return RedirectToAction("Index");
		}

		public ActionResult Edit(long? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}

			Filme filme = context.Filmes.Find(id);
			if (filme == null)
			{
				return HttpNotFound();
			}

			return View(filme);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(Filme filme)
		{
			if (ModelState.IsValid)
			{
				context.Entry(filme).State = EntityState.Modified;
				context.SaveChanges();
				return RedirectToAction("Index");
			}

			return View(filme);
		}
		public ActionResult Details(long? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}

			Filme Filme= context.Filmes.Find(id);

			if (Filme == null)
			{
				return HttpNotFound();
			}
			return View(Filme);
		}


		public ActionResult Delete(long? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			Filme filme = context.Filmes.Find(id);

			if (filme == null)
			{
				return HttpNotFound();
			}
			return View(filme);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(long id)
		{
			Filme filme = context.Filmes.Find(id);
			context.Filmes.Remove(filme);
			context.SaveChanges();
			return RedirectToAction("Index");
		}

	}
}