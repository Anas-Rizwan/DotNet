using Airline_Reservation_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Airline_Reservation_System.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Registration(int id = 0)
        {
            Registration user = new Registration();

            return View();
        }

        [HttpPost]

        public ActionResult Registration(Registration user)
        {

            using (RegistrationModel db_reg = new RegistrationModel())
            {
                if (db_reg.Registrations.Any(x=> x.CNIC == user.CNIC))
                {
                    ViewBag.DuplicateMessage = "CNIC No Already Exist";
                    return View("Registration", user);
                }
                else
                {
                    db_reg.Registrations.Add(user);
                    db_reg.SaveChanges();
                    
                }

                return View("Registration", new Registration());
            }
           
        }

        public ActionResult Login(int id = 0)
        {
            Registration user = new Registration();

            return View();
        }

        [HttpPost]
        public ActionResult Login(Registration user)
        {
            //Air_Reg user = new Air_Reg();
            using (RegistrationModel db_reg = new RegistrationModel())
            {
                if (db_reg.Registrations.Any(x => (x.CNIC == user.CNIC && x.Password == user.Password)))
                {
                    ViewBag.DuplicateMessage = "Login successful";
                    return View("Login", user);
                }
                else
                {
                    ViewBag.DuplicateMessage = "You Enter Wrong Cnic or Password";
                    return View("Login", user);
                }


            }
        }
    }
}