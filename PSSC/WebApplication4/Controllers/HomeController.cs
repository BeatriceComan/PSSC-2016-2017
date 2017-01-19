using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/


        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Index(MainModel mainModel)
        {
            if (ModelState.IsValid) // Check the model state for any validation errors
            {
                if (mainModel.login.checkUser(mainModel.login.RegNumber, mainModel.login.Password)) // Calls the Login class checkUser() for existence of the user in the database.
                {
                    DataSet ds = mainModel.GetAllSubjects(mainModel.login.RegNumber);
                    ViewBag.SubjectsList = ds.Tables[0];
                    return View("Show", mainModel); // Return the "Show.cshtml" view if user is valid
                }
                else
                {
                    ViewBag.Message = "Invalid Registration Number or Password";
                    return View(); //return the same view with message "Invalid Username or Password"
                }
            }
            else
            {
                return View(); // Return the same view with validation errors.
            }
        }
    }
}
