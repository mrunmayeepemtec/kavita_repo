using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MyApp.Core;

namespace CRUDAppEntityFrameworkUI.Controllers
{
    public class ProductController : Controller
    {
        private ProductEntities db = new ProductEntities();

        // GET: Product
        public ActionResult Index()
        {
            return View(db.tbl_ProductMaster.ToList());
        }

        // GET: Product/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_ProductMaster tbl_ProductMaster = db.tbl_ProductMaster.Find(id);
            if (tbl_ProductMaster == null)
            {
                return HttpNotFound();
            }
            return View(tbl_ProductMaster);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProductID,ProductName,Price,Qty,Remarks")] tbl_ProductMaster tbl_ProductMaster)
        {
            if (ModelState.IsValid)
            {
                db.tbl_ProductMaster.Add(tbl_ProductMaster);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_ProductMaster);
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_ProductMaster tbl_ProductMaster = db.tbl_ProductMaster.Find(id);
            if (tbl_ProductMaster == null)
            {
                return HttpNotFound();
            }
            return View(tbl_ProductMaster);
        }

        // POST: Product/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProductID,ProductName,Price,Qty,Remarks")] tbl_ProductMaster tbl_ProductMaster)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_ProductMaster).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_ProductMaster);
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_ProductMaster tbl_ProductMaster = db.tbl_ProductMaster.Find(id);
            if (tbl_ProductMaster == null)
            {
                return HttpNotFound();
            }
            return View(tbl_ProductMaster);
        }

        // POST: Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_ProductMaster tbl_ProductMaster = db.tbl_ProductMaster.Find(id);
            db.tbl_ProductMaster.Remove(tbl_ProductMaster);
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
