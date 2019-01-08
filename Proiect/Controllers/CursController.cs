using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using UPT.Data_Access_Layer;
using UPT.Models;

namespace UPT.Controllers
{
    public class CursController : Controller
    {
        private UnitOfWork unitOfWork = new UnitOfWork();

        // GET: Curs
        public ViewResult Index()
        {
            var cursuri = unitOfWork.CursRepository.Get(includeProperties: "Departament");
            return View(cursuri.ToList());
        }

        // GET: Curs/Details/5
        public ActionResult Details(int? id)
        {
            Curs curs = unitOfWork.CursRepository.GetByID(id);
            return View(curs);
        }

        // GET: Curs/Create
        public ActionResult Create(int id)
        {
            //ViewBag.IDDepartament = new SelectList(db.Departamente, "IDDepartament", "Nume");
            Curs curs = unitOfWork.CursRepository.GetByID(id);
            ListaDepartamente(curs.IDDepartament);
            return View();
        }

        // POST: Curs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDCurs,Titlu,Credite,IDDepartament")] Curs curs)
        {
            if (ModelState.IsValid)
            {
                unitOfWork.CursRepository.Insert(curs);
                unitOfWork.Save();
                return RedirectToAction("Index");
            }

            ListaDepartamente(curs.IDDepartament);
            return View(curs);
        }

        // GET: Curs/Edit/5
        public ActionResult Edit(int id)
        {
            Curs curs = unitOfWork.CursRepository.GetByID(id);
            ListaDepartamente(curs.IDDepartament);
            return View(curs);
        }

        // POST: Curs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDCurs,Titlu,Credite,IDDepartament")] Curs curs)
        {
            if (ModelState.IsValid)
            {
                unitOfWork.CursRepository.Update(curs);
                unitOfWork.Save();
                return RedirectToAction("Index");
            }
            ListaDepartamente(curs.IDDepartament);
           // ViewBag.IDDepartament = new SelectList(db.Departamente, "IDDepartament", "Nume", curs.IDDepartament);
            return View(curs);
        }

        private void ListaDepartamente(object departamentSelectat = null)
        {
            var departamente = unitOfWork.DepartamentRepository.Get(
                orderBy: q => q.OrderBy(d => d.Nume));
            ViewBag.DepartmentID = new SelectList(departamente, "DepartamentID", "Nume", departamentSelectat);
        }

        // GET: Curs/Delete/5
        public ActionResult Delete(int? id)
        {
            Curs curs = unitOfWork.CursRepository.GetByID(id);
            return View(curs);
        }

        // POST: Curs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Curs curs = unitOfWork.CursRepository.GetByID(id);
            unitOfWork.CursRepository.Delete(id);
            unitOfWork.Save();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                unitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
