using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AirlineRegistration.Models;

namespace AirlineRegistration.Controllers
{
    public class RegistrationController : Controller
    {
        public ActionResult RegistrationHome()
        {
         

            return View();
        }
        // GET: Registration
        public ActionResult Registration(int id = 0)
        {
            Air_Reg user = new Air_Reg();

            return View();
        }

        [HttpPost]

        public ActionResult Registration(Air_Reg user)
        {

            using (AirlineRegistrationsDBEntities reg = new AirlineRegistrationsDBEntities())
            {
                if (reg.Air_Reg.Any(x => x.Cnic == user.Cnic))
                {
                    ViewBag.DuplicateMessage = "CNIC No Already Exist";
                    return View("Registration", user);
                }
                else
                {
                    reg.Air_Reg.Add(user);
                    reg.SaveChanges();

                }


            }
            return View("Registration", new Air_Reg());
        }

        public ActionResult login(int id = 0)
        {
            Air_Reg user = new Air_Reg();

            return View();
        }

        [HttpPost]
        public ActionResult Login(Air_Reg user)
        {
            //Air_Reg user = new Air_Reg();
            using (AirlineRegistrationsDBEntities reg = new AirlineRegistrationsDBEntities())
            {
                 if(reg.Air_Reg.Any(x => (x.Cnic == user.Cnic && x.Password == user.Password)))
                {
                     ViewBag.DuplicateMessage = "Login successful";
                     return View("Login",user);
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