using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using UPT.Data_Access_Layer;
using UPT.Models;

namespace UPT.Controllers
{
    public class DepartamentController : Controller
    {
        private UnitOfWork unitOfWork = new UnitOfWork();

        // GET: Departament
        public ViewResult Index()
        {
            var departamente = unitOfWork.DepartamentRepository.Get();
            return View( departamente.ToList());
        }

        // GET: Departament/Details/5
        public ActionResult Details(int? id)
        {
            Departament departament = unitOfWork.DepartamentRepository.GetByID(id);
            return View(departament);
        }

        // GET: Departament/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Departament/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDDepartament,Nume,Buget,DataInceperii,IDProfesor")] Departament departament)
        {
            if (ModelState.IsValid)
            {
                unitOfWork.DepartamentRepository.Insert(departament);
                unitOfWork.Save();
                return RedirectToAction("Index");
            }

            return View(departament);
        }

        // GET: Departament/Edit/5
        public ActionResult Edit(int? id)
        {
            Departament departament = unitOfWork.DepartamentRepository.GetByID(id);
            return View(departament);
        }

        // POST: Departament/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDDepartament,Nume,Buget,DataInceperii,IDProfesor")] Departament departament)
        {
            if (ModelState.IsValid)
            {
                unitOfWork.DepartamentRepository.Update(departament);
                unitOfWork.Save();
                return RedirectToAction("Index");
            }
            return View(departament);
        }

        // GET: Departament/Delete/5
        public ActionResult Delete(int? id)
        {
            Departament departament = unitOfWork.DepartamentRepository.GetByID(id);
            return View(departament);
        }

        // POST: Departament/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Departament departament = unitOfWork.DepartamentRepository.GetByID(id);
            unitOfWork.DepartamentRepository.Delete(id);
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
