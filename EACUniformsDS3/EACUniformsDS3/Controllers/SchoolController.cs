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
    public class SchoolController : Controller
    {
        private MyBizRMSDBContext db = new MyBizRMSDBContext();

        // GET: /School/
        public ActionResult Index()
        {
            return View(db.School.ToList());
        }

        // GET: /School/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            School school = db.School.Find(id);
            if (school == null)
            {
                return HttpNotFound();
            }
            return View(school);
        }

        // GET: /School/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /School/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="school_Id,school_Name,address_Line1,address_Line2,suburb,city,postal_Code,contact_Person,Contact_eMail_Address,contact_Number")] School school)
        {
            if (ModelState.IsValid)
            {
                db.School.Add(school);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(school);
        }

        // GET: /School/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            School school = db.School.Find(id);
            if (school == null)
            {
                return HttpNotFound();
            }
            return View(school);
        }

        // POST: /School/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="school_Id,school_Name,address_Line1,address_Line2,suburb,city,postal_Code,contact_Person,Contact_eMail_Address,contact_Number")] School school)
        {
            if (ModelState.IsValid)
            {
                db.Entry(school).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(school);
        }

        // GET: /School/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            School school = db.School.Find(id);
            if (school == null)
            {
                return HttpNotFound();
            }
            return View(school);
        }

        // POST: /School/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            School school = db.School.Find(id);
            db.School.Remove(school);
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

        public static List<SelectListItem> GetAllSchools()
        {
            MyBizRMSDBContext db = new MyBizRMSDBContext();
            List<SelectListItem> ls = new List<SelectListItem>();

            var supp = db.School.ToList();
            foreach (var temp in supp)
            {
                    ls.Add(new SelectListItem() { Text = temp.school_Name, Value = temp.school_Name });

            }
            return ls;
        }
    }
}
