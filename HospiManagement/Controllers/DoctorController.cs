using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HospiManagement.Models;

namespace HospiManagement.Controllers
{
    public class DoctorController : Controller
    {
        // GET: Doctor
        public ActionResult Index()
        {
            DBContext db = new DBContext();
            
            var specialty = db.Specialties.ToList();
            

            //foreach(var name in data)
            //{


            //}

            return View(specialty);

      

        }
        /*
        [HttpGet]
        public ActionResult AddDoctor()
        {
            DBContext db = new DBContext();
            Doctor d = new Doctor();

            var list = from item in db.Specialties select item.Name;
            foreach(var a in list)
            {
                d.specialtylist.Add(a);
            }

            return View();
        }

        [HttpPost]
        public ActionResult AddDoctor(Doctor doctor)
        {
            DBContext dbcontext = new DBContext();
            int contact = Convert.ToInt32( doctor.Contact);
            if(contact < 0)
            {
                ViewBag.Error = "Please enter valid number";
            }
            else
            {
                dbcontext.Doctors.Add(doctor);
                ViewBag.success = "Entry successfull";
            }

            return View();
        }

    */
    }
}