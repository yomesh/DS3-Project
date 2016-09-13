using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EACUniformsDS3.Models;
using EACUniformsDS3.DAL;

namespace EACUniformsDS3.Controllers
{
    public class OrderController : Controller
    {
        public MyBizRMSDBContext db = new MyBizRMSDBContext();

        // GET: /Order/
        public ActionResult Index()
        {
            return View(db.Order.ToList());
        }

        // GET: /Order/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = db.Order.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // GET: /Order/Create
        public ActionResult Create()


        {

            int sss = db.Order.Count();
            sss = sss + 1;
            Session["OrderId"] = sss;
            Session["Supplier"] = "Padayachee";
            ViewBag.OrderId = sss;
            return View("Multi");
        }

        // POST: /Order/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="OrderId,OrderDate,Supplier,ExpectedDeliveryDate,OrderedByUser,Status,total")] Order order)
        {
            if (ModelState.IsValid)
            {
                db.Order.Add(order);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(order);
        }

        public PartialViewResult _GetOrderItems (Order ord)
        {
            List<OrdItem> orditems = db.OrdItem.Where(m => m.OrderId == ord.OrderId).ToList();
            Session["sup"] = ord.Supplier;

            return PartialView("_GetOrderItems", orditems);
        }

        [ChildActionOnly]
        public PartialViewResult _AddForm (int orderid)
        {
            OrdItem orditem = new OrdItem() { OrderId = orderid };
            return PartialView("_AddForm", orditem);
        }

        public PartialViewResult _Submit(OrdItem orditem)
        {
            int ind = db.OrdItem.Count(w => w.OrderId == orditem.OrderId);
            ind = ind + 1;
            orditem.item_Id = ind;
            var supp = db.Item.FirstOrDefault(w => w.description == orditem.description);
            orditem.UnitPrice = supp.Cprice;
            orditem.total = Convert.ToDouble(orditem.Quantity * orditem.UnitPrice);
            orditem.OrderDate = DateTime.Now;
            orditem.vat = 14;
            orditem.RecQuantity = 0;
            orditem.Supplier = Session["Supplier"].ToString();
            db.OrdItem.Add(orditem);
            db.SaveChanges();

            List<OrdItem> orditems = db.OrdItem.Where(w => w.OrderId == orditem.OrderId).ToList();
            ViewBag.OrderId = orditem.OrderId;
            return PartialView("_GetOrderItems", orditems);
        }

        // GET: /Order/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = db.Order.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // POST: /Order/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="OrderId,OrderDate,Supplier,ExpectedDeliveryDate,OrderedByUser,Status,total")] Order order)
        {
            if (ModelState.IsValid)
            {
                db.Entry(order).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(order);
        }

        // GET: /Order/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = db.Order.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // POST: /Order/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Order order = db.Order.Find(id);
            db.Order.Remove(order);
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

        public ActionResult testing ()
        {
            return View();
        }


    }
}
