using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IMDB_2._0___Entity.Context;
using IMDB_2._0___Entity.Models;

namespace IMDB_2._0___Entity.Controllers
{
    public class AtuacoesController : Controller
    {
        private EFContext context = new EFContext();

        // GET: Atuacoes
        public ActionResult Index()
        {
            var atuacoes = context.atuacoes.Include(a => a.ator).Include(f => f.filme).OrderBy(n => n.atuacaoId);
            return View(atuacoes);
        }

        // GET: Atuacoes/Create
        public ActionResult Create()
        {
            ViewBag.AtorId = new SelectList(context.atores.OrderBy(a => a.nome), "AtorId", "Nome");
            ViewBag.FilmeId = new SelectList(context.Filmes.OrderBy(f => f.titulo), "FilmeId", "Titulo");
            return View();
        }

        // POST: Atuacoes/Create
        [HttpPost]
        public ActionResult Create(Atuacao atuacao)
        {
            context.atuacoes.Add(atuacao);
            context.SaveChanges();
            return RedirectToAction("Index");

        }

        // GET: Atuacoes/Delete
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.
                BadRequest);
            }
            Atuacao atuacao = context.atuacoes.Where(a => a.atuacaoId ==
            id).Include(at => at.ator).Include(f => f.filme).
            First();
            if (atuacao == null)
            {
                return HttpNotFound();
            }
            return View(atuacao);
        }

        [HttpPost]
        public ActionResult Delete(long id)
        {
            Atuacao atuacao = context.atuacoes.Find(id);
            context.atuacoes.Remove(atuacao);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
