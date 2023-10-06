using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        public ActionResult Admin()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }


        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickts,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                insuree.Quote = Calculate(insuree);
                db.Insurees.Add(insuree); 
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }


        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickts,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                insuree.Quote = Calculate(insuree);
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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

        public decimal Calculate(Insuree insuree)
        {
            decimal EstimatedQuote = 50m;
            int Age = DateTime.Now.Year - insuree.DateOfBirth.Year;

            //this calcuates what to the quote for age
            if (Age <= 18){EstimatedQuote += 100m;}
            else if (Age >= 19 && Age <= 25) { EstimatedQuote += 50m;}
            else if (Age >= 26){EstimatedQuote += 25m;}
            //end of age calculation

            //this calculates what to add to the quote for car year
            if (insuree.CarYear < 2000) { EstimatedQuote += 25m; }
            else if (insuree.CarYear > 2015) { EstimatedQuote += 25m; }
            //end of year calculation

            //this calculates what to add to the quote for the type of car
            if (insuree.CarMake.ToLower() == "porsche" && insuree.CarModel.ToLower() == "911 Carrera") { EstimatedQuote += 50m; }
            else if (insuree.CarMake.ToLower() == "porsche") { EstimatedQuote += 25m; }
            //end of calculating type of car

            //this calculates what to add to the quote for speeding tickets
            if(insuree.SpeedingTickts > 0) { EstimatedQuote += insuree.SpeedingTickts * 10m; }
            //end of calculating speeding tickets

            //this calculates what to add to the quote for DUI
            if (insuree.DUI == true) { EstimatedQuote *= 1.25m; }
            //end of calculating DUI

            //this caluclates what to add to the quote for full coverage
            if (insuree.CoverageType == true) { EstimatedQuote *= 1.50m; }
            //end of calculating coverage

            insuree.Quote = EstimatedQuote;

            return (insuree.Quote);

        }
    }
}
