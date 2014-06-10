using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using it.ModelsDefault1;

namespace it.Controllers
{
    public class CandidatosController : Controller
    {
        private Db db = new Db();

        // GET: /Candidatos/
        public ActionResult Index()
        {
            return View(db.Candidatos.ToList());
        }
        public ActionResult Novo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Salvar(Candidatos candidato)
        {
            if (ModelState.IsValid)
            {
                db.Candidatos.Add(candidato);
                db.SaveChanges();
                return View("Index");
            }
            else
            {
                return View("Novo",candidato);
            }

        }
        // GET: /Candidatos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Candidatos candidatos = db.Candidatos.Find(id);
            if (candidatos == null)
            {
                return HttpNotFound();
            }
            return View(candidatos);
        }

        // GET: /Candidatos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Candidatos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="CandidatoID,Nome,Sexo,CNH,BirthDate,EstadoCivil,Telefone,Celular,Email,Endereco,Cidade,Estado")] Candidatos candidatos)
        {
            if (ModelState.IsValid)
            {
                db.Candidatos.Add(candidatos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(candidatos);
        }

        // GET: /Candidatos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Candidatos candidatos = db.Candidatos.Find(id);
            if (candidatos == null)
            {
                return HttpNotFound();
            }
            return View(candidatos);
        }

        // POST: /Candidatos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="CandidatoID,Nome,Sexo,CNH,BirthDate,EstadoCivil,Telefone,Celular,Email,Endereco,Cidade,Estado")] Candidatos candidatos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(candidatos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(candidatos);
        }

        // GET: /Candidatos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Candidatos candidatos = db.Candidatos.Find(id);
            if (candidatos == null)
            {
                return HttpNotFound();
            }
            return View(candidatos);
        }

        // POST: /Candidatos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Candidatos candidatos = db.Candidatos.Find(id);
            db.Candidatos.Remove(candidatos);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
