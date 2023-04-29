using Airline_Reservation_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Windows.Documents;

namespace Airline_Reservation_System.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Admin()
        {
            return View();
        }


        // GET: Shedule
        public ActionResult Shedule(int id = 0)
        {

            Admin flight_shedule = new Admin();
            return View();
        }

        [HttpPost]

        public ActionResult Shedule(Admin flight_shedule)
        {
            using (AdminModel ad_db = new AdminModel())
            {
                if (flight_shedule.AirlineName == " " )
                {
                    ViewBag.DuplicateMessage = "The Field is Empty";
                    return View("Shedule", flight_shedule);
                }
                else
                {
                    ad_db.Admins.Add(flight_shedule);
                    ad_db.SaveChanges();
                    
                }
                return View("Admin", new Admin());

            }
        }

        public ActionResult Flight_Details()
        {
            using (AdminModel db_admin = new AdminModel())
            {

                return View(db_admin.Admins.ToList());
            }
        }

        [HttpGet]
        public ActionResult Flight_Edit()
        {
            return View();
        }

        public ActionResult Register_user()
        {
            using(RegistrationModel db_reg = new RegistrationModel())
            {
                
                return View(db_reg.Registrations.ToList());
            }
        }
       
        //public ActionResult Admin_user(int id = 0)
        //{
        //    //Registration user = new Registration();
        //    return View();
        //}
    }
}