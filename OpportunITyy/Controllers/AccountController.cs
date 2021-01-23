using Cassandra;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OpportunITyy.Data;
using OpportunITyy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpportunITyy.Controllers
{
    public class AccountController : Controller
    {
        
        readonly ISession session = SessionManager.GetSession();
        public static string EmailUser { get; set; }
        static string EmailFirm { get; set; }
        [HttpGet]
        public IActionResult RegisterUser()
        {

            return View();
        }

        [HttpPost]
        public IActionResult RegisterUser(User u)
        {
            if (u.Email!= null && u.Password==u.ConfirmPassword)
            {

                string pw = BCrypt.Net.BCrypt.HashPassword(u.Password);
                RowSet newUser = session.Execute("insert into opportunity.user (email,password,fname,lname) values ( '" + u.Email + "', '" + pw + "', '" + u.FName + "', '" + u.LName + "')");
                return RedirectToAction("AddMoreInfo", "User", new { email = u.Email });
            }
            else
                return View(u);
        }

        
       


        [HttpGet]
        public IActionResult RegisterFirm()
        {

            return View();
        }



        [HttpPost]
        public IActionResult RegisterFirm(Firm f)
        {
            if (f.Email != null && f.Password == f.ConfirmPassword)
            {
                string pw = BCrypt.Net.BCrypt.HashPassword(f.Password);
                Guid guid = Guid.NewGuid();
                RowSet newFirm = session.Execute("insert into opportunity.firm (email,password) values ('" + f.Email + "', '" + pw + "')");
                return RedirectToAction("AddMoreInfoFirm", "Firm", new { email = f.Email });
            }
            else
                return View(f);
        }


        
       
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel acc)
        {
            Row rowForUser = session.Execute("select * from user where email='" + acc.Email + "'").FirstOrDefault();
            
            if (rowForUser != null)
            {
                var result = rowForUser.GetValue<string>("email");

                if (result != null)
                {
                    if (BCrypt.Net.BCrypt.Verify(acc.Password, rowForUser.GetValue<string>("password")))
                    {

                        return RedirectToAction("UserSignedIn", "User", new { email = acc.Email });
                    }
                    else
                    {
                        ModelState.AddModelError("message", "Invalid login attempt");
                        return View(acc);
                    }

                }
                else

                {
                    ModelState.AddModelError("message", "Invalid login attempt");
                    return View(acc);
                }
            }
            Row rowForFirm = session.Execute("select * from firm where email='" + acc.Email + "'").FirstOrDefault();
            if (rowForFirm != null)
            {


                var resultt = rowForFirm.GetValue<string>("email");

                if (resultt != null)
                {
                    if (BCrypt.Net.BCrypt.Verify(acc.Password, rowForFirm.GetValue<string>("password")))
                    {

                        return RedirectToAction("FirmSignedIn", "Firm", new { email = acc.Email });
                    }
                    else
                    {
                        ModelState.AddModelError("message", "Invalid login attempt");
                        return View(acc);
                    }

                }
                else

                {
                    ModelState.AddModelError("message", "Invalid login attempt");
                    return View(acc);
                }
            }
            else
            {
                ModelState.AddModelError("message", "Invalid login attempt");
                return View(acc);
            }
        }
        
       
    }
}