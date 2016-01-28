using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using mywebtest56.Models;

namespace mywebtest56.Controllers
{
    public class CustomerDetailsController : Controller
    {
        private Customer db = new Customer();

        // GET: CustomerDetails
        public ActionResult Index()
        {
            return View(db.CustomerDetails.ToList());
        }

        // GET: CustomerDetails/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerDetail customerDetail = db.CustomerDetails.Find(id);
            if (customerDetail == null)
            {
                return HttpNotFound();
            }
            return View(customerDetail);
        }

        // GET: CustomerDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CustID,CustName,Email,City,Phone")] CustomerDetail customerDetail)
        {
            if (ModelState.IsValid)
            {
                db.CustomerDetails.Add(customerDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(customerDetail);
        }

        // GET: CustomerDetails/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerDetail customerDetail = db.CustomerDetails.Find(id);
            if (customerDetail == null)
            {
                return HttpNotFound();
            }
            return View(customerDetail);
        }

        // POST: CustomerDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CustID,CustName,Email,City,Phone")] CustomerDetail customerDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customerDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customerDetail);
        }

        // GET: CustomerDetails/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerDetail customerDetail = db.CustomerDetails.Find(id);
            if (customerDetail == null)
            {
                return HttpNotFound();
            }
            return View(customerDetail);
        }

        // POST: CustomerDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            CustomerDetail customerDetail = db.CustomerDetails.Find(id);
            db.CustomerDetails.Remove(customerDetail);
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
