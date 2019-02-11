using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MoodMeApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MoodMeApp.Controllers
{
    public class SignupController : Controller
    {
        // GET: /<controller>/

       public ActionResult Signup()
        {
            return View();
        } 

        [HttpPost]
        public ActionResult Signup(Signup account)
        {
            if (ModelState.IsValid)
            {
                using (AppDbContext db = new AppDbContext())
                {
                    db.userAccount.Add(account);
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = account.FirstName + " " + account.LastName + " succesfully registered.";
            }
            return View();
        }
            
    }
}
