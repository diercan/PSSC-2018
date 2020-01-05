using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using UPT.Data_Access_Layer;
using UPT.Models;
using UPT.ViewModels;

namespace UPT.Controllers
{
    public class ProfesorController : Controller
    {
        private ContextUniversitate db = new ContextUniversitate();

        // GET: Profesor
        public ActionResult Index(int? id, int? IDCurs)
        {
            var viewModel = new ProfesorIndexData();
            viewModel.Profesori = db.Profesori
                .Include(i => i.Cabinet)
                .Include(i => i.Cursuri.Select(c => c.Departament))
                .OrderBy(i => i.Nume);

            if (id != null)
            {
                ViewBag.IDProfesor = id.Value;
                viewModel.Cursuri = viewModel.Profesori.Where(
                    i => i.ID == id.Value).Single().Cursuri;
            }

            if (IDCurs != null)
            {
                ViewBag.CourseID = IDCurs.Value;

                var cursSelectat = viewModel.Cursuri.Where(x => x.IDCurs == IDCurs).Single();
                db.Entry(cursSelectat).Collection(x => x.Inscriere).Load();
                foreach (Inscriere inscriere in cursSelectat.Inscriere)
                {
                    db.Entry(inscriere).Reference(x => x.Student).Load();
                }

                viewModel.Inscriere = cursSelectat.Inscriere;
            }

            return View(viewModel);
        }
        // GET: Profesor/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Profesor profesor = db.Profesori.Find(id);
            if (profesor == null)
            {
                return HttpNotFound();
            }
            return View(profesor);
        }

        // GET: Profesor/Create
        public ActionResult Create()
        {
            var prof = new Profesor();
            prof.Cursuri = new List<Curs>();
            TitularCurs(prof);
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Nume,Prenume,DataANgajarii,Cabinet")]Profesor profesor, string[] cursuriSelectate)
        {
            if (cursuriSelectate != null)
            {
                profesor.Cursuri = new List<Curs>();
                foreach (var curs in cursuriSelectate)
                {
                    var cursNou = db.Cursuri.Find(int.Parse(curs));
                    profesor.Cursuri.Add(cursNou);
                }
            }
            if (ModelState.IsValid)
            {
                db.Profesori.Add(profesor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            TitularCurs(profesor);
            return View(profesor);
        }

        // GET: Profesor/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Profesor profesor = db.Profesori
             .Include(i => i.Cabinet)
             .Include(i => i.Cursuri)
             .Where(i => i.ID == id)
            .Single();
            TitularCurs(profesor);
            if (profesor == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID = new SelectList(db.Cabinete, "IDProfesor", "LocatieCabinet", profesor.ID);
            return View(profesor);
        }

        private void TitularCurs(Profesor profesor)
        {
            var cursuri = db.Cursuri;
            var cursuriProf = new HashSet<int>(profesor.Cursuri.Select(c => c.IDCurs));
            var viewModel = new List<ImpartireCursuri>();
            foreach (var curs in cursuri)
            {
                viewModel.Add(new ImpartireCursuri
                {
                    IDCurs = curs.IDCurs,
                    Titlu = curs.Titlu,
                    Titular = cursuriProf.Contains(curs.IDCurs)
                });
            }
            ViewBag.Cursuri = viewModel;
        }
        // POST: Profesor/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int? id, string[] cursuriSelectate)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var profesoriUpdate = db.Profesori
               .Include(i => i.Cabinet)
               .Include(i => i.Cursuri)
               .Where(i => i.ID == id)
               .Single();

            if (TryUpdateModel(profesoriUpdate, "",
               new string[] { "Nume", "Prenume", "DataAngajarii", "Cabinet" }))
            {
                try
                {
                    if (String.IsNullOrWhiteSpace(profesoriUpdate.Cabinet.LocatieCabinet))
                    {
                        profesoriUpdate.Cabinet = null;
                    }
                    UpdateCursuri(cursuriSelectate, profesoriUpdate);
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
                catch (RetryLimitExceededException /* dex */)
                {
                    //Log the error (uncomment dex variable name and add a line here to write a log.
                    ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
                }
            }
            TitularCurs(profesoriUpdate);
            return View(profesoriUpdate);
        }

        private void UpdateCursuri(string[] cursuriSelectate, Profesor profUpdate)
        {
            if (cursuriSelectate == null)
            {
                profUpdate.Cursuri = new List<Curs>();
                return;
            }

            var cursuriSelectateHS = new HashSet<string>(cursuriSelectate);
            var profesorCurs = new HashSet<int>
                (profUpdate.Cursuri.Select(c => c.IDCurs));
            foreach (var curs in db.Cursuri)
            {
                if (cursuriSelectate.Contains(curs.IDCurs.ToString()))
                {
                    if (!profesorCurs.Contains(curs.IDCurs))
                    {
                        profUpdate.Cursuri.Add(curs);
                    }
                }
                else
                {
                    if (profesorCurs.Contains(curs.IDCurs))
                    {
                        profUpdate.Cursuri.Remove(curs);
                    }
                }
            }
        }

        // GET: Profesor/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Profesor profesor = db.Profesori.Find(id);
            if (profesor == null)
            {
                return HttpNotFound();
            }
            return View(profesor);
        }

        // POST: Profesor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Profesor profesor = db.Profesori.Find(id);
            db.Profesori.Remove(profesor);
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
