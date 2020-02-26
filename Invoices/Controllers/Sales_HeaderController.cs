using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Invoices.Data_Access_Layer;
using Invoices.Models;

namespace Invoices.Controllers
{
    public class Sales_HeaderController : Controller
    {
        private InvoicesContext db = new InvoicesContext();

        // GET: Sales_Header
        public ActionResult Index()
        {
            return View(db.Sales_Header.ToList());
        }

        // GET: Sales_Header/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sales_Header sales_Header = db.Sales_Header.Find(id);
            if (sales_Header == null)
            {
                return HttpNotFound();
            }
            return View(sales_Header);
        }

        // GET: Sales_Header/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sales_Header/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Document_Date,Customer,Vat_Reg_No,Service_Date")] Sales_Header sales_Header)
        {
            if (ModelState.IsValid)
            {
                db.Sales_Header.Add(sales_Header);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sales_Header);
        }

        // GET: Sales_Header/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sales_Header sales_Header = db.Sales_Header.Find(id);
            if (sales_Header == null)
            {
                return HttpNotFound();
            }
            return View(sales_Header);
        }

        // POST: Sales_Header/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Document_Date,Customer,Vat_Reg_No,Service_Date")] Sales_Header sales_Header)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sales_Header).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sales_Header);
        }

        // GET: Sales_Header/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sales_Header sales_Header = db.Sales_Header.Find(id);
            if (sales_Header == null)
            {
                return HttpNotFound();
            }
            return View(sales_Header);
        }

        // POST: Sales_Header/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sales_Header sales_Header = db.Sales_Header.Find(id);
            db.Sales_Header.Remove(sales_Header);
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
