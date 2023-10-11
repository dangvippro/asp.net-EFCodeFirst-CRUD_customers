using MidTerm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MidTerm.Controllers
{
    public class CustomerController : Controller
    {
        CustomerDBContext db = new CustomerDBContext();
        // GET: Customer
        public ActionResult Index()
        {
            List<Customer> list = db.Customers.ToList();
            return View(list);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customer cus)
        {
            if(ModelState.IsValid) 
            {
                db.Customers.Add(cus);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Create");
            }
           
        }

        public ActionResult Update(string id)
        {
            Customer cus = db.Customers.Where(row => row.id == id).FirstOrDefault();
            return View(cus);
        }

        [HttpPost]
        public ActionResult Update (Customer cus)
        {
            Customer updateCus = db.Customers.Where(row => row.id == cus.id).FirstOrDefault();
            //update
            updateCus.fullname = cus.fullname;
            updateCus.birthday = cus.birthday;
            updateCus.gender = cus.gender;
            updateCus.email = cus.email;
            updateCus.phone = cus.phone;
            updateCus.address = cus.address;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(string id)
        {
            Customer delCus = db.Customers.Where(row => row.id == id).FirstOrDefault();
            db.Customers.Remove(delCus);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}