using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VLS.Models;
using VLS.Models.Entiteis;

namespace VLS.Areas.Representation.Controllers
{
    public class VehiclesController : Controller
    {
        private DataContext db = new DataContext();

        // GET: Representation/Vehicles
        public ActionResult Index()
        {
            var vehicles = db.Vehicles.Include(v => v.Customers).Include(v => v.vehichtype);
            return View(vehicles.ToList());
        }

        // GET: Representation/Vehicles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vehicle vehicle = db.Vehicles.Find(id);
            if (vehicle == null)
            {
                return HttpNotFound();
            }
            return View(vehicle);
        }

        // GET: Representation/Vehicles/Create
        public ActionResult Create()
        {
            ViewBag.CustomerId = new SelectList(db.Customers, "Id", "FullName");
            ViewBag.TypeId = new SelectList(db.Vehicletypes, "TypeId", "TypeName");
            return View();
        }

        // POST: Representation/Vehicles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VehicleId,VehicleName,VehicleNo,CustomerId,RegisterDate,ExpireDate,TypeId")] Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                db.Vehicles.Add(vehicle);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CustomerId = new SelectList(db.Customers, "Id", "FullName", vehicle.CustomerId);
            ViewBag.TypeId = new SelectList(db.Vehicletypes, "TypeId", "TypeName", vehicle.TypeId);
            return View(vehicle);
        }

        // GET: Representation/Vehicles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vehicle vehicle = db.Vehicles.Find(id);
            if (vehicle == null)
            {
                return HttpNotFound();
            }
            ViewBag.CustomerId = new SelectList(db.Customers, "Id", "FullName", vehicle.CustomerId);
            ViewBag.TypeId = new SelectList(db.Vehicletypes, "TypeId", "TypeName", vehicle.TypeId);
            return View(vehicle);
        }

        // POST: Representation/Vehicles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VehicleId,VehicleName,VehicleNo,CustomerId,RegisterDate,ExpireDate,TypeId")] Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vehicle).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CustomerId = new SelectList(db.Customers, "Id", "FullName", vehicle.CustomerId);
            ViewBag.TypeId = new SelectList(db.Vehicletypes, "TypeId", "TypeName", vehicle.TypeId);
            return View(vehicle);
        }

        // GET: Representation/Vehicles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vehicle vehicle = db.Vehicles.Find(id);
            if (vehicle == null)
            {
                return HttpNotFound();
            }
            return View(vehicle);
        }

        // POST: Representation/Vehicles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Vehicle vehicle = db.Vehicles.Find(id);
            db.Vehicles.Remove(vehicle);
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
