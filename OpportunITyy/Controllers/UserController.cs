using Cassandra;
using Cassandra.Mapping;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OpportunITyy.Data;
using OpportunITyy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.FileProviders;

namespace OpportunITyy.Controllers
{
    public class UserController : Controller
    {
        private static string LoggedUser { get; set; }
        readonly Cassandra.ISession session = SessionManager.GetSession();
        readonly IMapper mapper = new Mapper(SessionManager.GetSession());
        private static object objLock = new object();
        public IActionResult Index()
        {
            return View();
        }
        public static string GetLoggedUser(string email)
        {

            if (LoggedUser == null)
            {
                lock (objLock)
                {
                    if (LoggedUser == null)
                    {
                        LoggedUser = email;
                    }
                }
            }

            return LoggedUser;
        }
        public IActionResult UserSignedIn(string email, string typeofjob)
        {
            ViewBag.Email = email;
            GetLoggedUser(email);
            

            List<Ad> ads;
            if (typeofjob == null)
            {
                ads = mapper.Fetch<Ad>("SELECT * from ad").ToList();
            } 
            else
            {
                ads = mapper.Fetch<Ad>("SELECT * from ad where typeofjob='" + typeofjob + "'").ToList();
            }

            return View(ads);
            
        }
        public IActionResult UserProfile()
        {

            User user = mapper.Fetch<User>("SELECT * FROM user WHERE email='" + GetLoggedUser(null) + "'").FirstOrDefault();
            ViewBag.email = GetLoggedUser(null);
            

            return View(user);
        }
        public IActionResult AdProfile(Guid idAd, string typeofJob, string email)
        {
            bool indicator = false;
            bool indicatora = false;
            Ad ad = mapper.Fetch<Ad>("SELECT * from opportunity.ad where typeofjob='" + typeofJob + "' AND idad = " + idAd + "").FirstOrDefault();
            if (ad.EmailFirm != email)
            {
                session.Execute("insert into opportunity.user_ads_history (email,idad,time,typeofjob) values ('" + GetLoggedUser(null) + "'," + idAd + ", toTimestamp(now()), '" + typeofJob + "' )");
            }

            User u = mapper.Fetch<User>("SELECT * FROM opportunity.user WHERE email='" + GetLoggedUser(null) + "'").FirstOrDefault();
            foreach (var item in u.AdSaved)
                if (item.Key == idAd)
                    indicator = true;

            List<Ads_user_applied> applied = mapper.Fetch<Ads_user_applied>("SELECT * FROM ads_user_applied where email='" + LoggedUser + "'").ToList();
            foreach(var item in applied)
            if(item.IdAd == idAd)
                    indicatora = true;

            ViewBag.Indicator = indicator;
            ViewBag.Indicatora = indicatora;
            return View(ad);

        }
        public IActionResult GetUserHistory()
        {
            List<User_ads_history> history = new List<User_ads_history>();
            history = mapper.Fetch<User_ads_history>("SELECT * FROM user_ads_history where email='" + GetLoggedUser(null) + "' ").ToList();
            var h= history.GroupBy(x => x.idad).Select(x => x.First()).ToList();
            
            return View(h);
            
        }


        [HttpGet]
        public ViewResult AddMoreInfo(bool isSucces = false)
        {


            ViewBag.Skills = new List<SelectListItem>()

            {
                new SelectListItem(){Text = "C++", Value="C++"},
                new SelectListItem(){Text = "C#", Value="C#"},
                new SelectListItem(){Text = "Java", Value="Java"},
                new SelectListItem(){Text = "C", Value="C"},
                new SelectListItem(){Text = "Python", Value="Python"},
                new SelectListItem(){Text = "Objective C", Value="Objective C"},
                new SelectListItem(){Text = "SQL", Value="SQL"},
                new SelectListItem(){Text = "Javascript", Value="Javascript"},
                new SelectListItem(){Text = "Ruby", Value="Ruby"},
                new SelectListItem(){Text = "Perl", Value="Perl"},
                new SelectListItem(){Text = "ActionScript", Value="ActionScript"},
                new SelectListItem(){Text = "Visual Basic", Value="Visual Basic"},
                new SelectListItem(){Text = "Lisp", Value="Lisp"},
                new SelectListItem(){Text = "Assembly", Value="Assembly"},
                new SelectListItem(){Text = "Scala", Value="Scala"},
                new SelectListItem(){Text = "Arduino", Value="Arduino"},


            };
            ViewBag.Education = new List<SelectListItem>()

            {
                new SelectListItem(){Text = "Associate degree", Value="Associate degree"},
                new SelectListItem(){Text = "Bachelor's degree", Value="Bachelor degree"},
                new SelectListItem(){Text = "Master's degree", Value="Master degree"},
                new SelectListItem(){Text = "Doctoral degree", Value="Doctoral degree"},

            };
            return View();

        }
        [HttpGet]
        public IActionResult EditUser()
        {
            ViewBag.Skills = new List<SelectListItem>()

            {
                new SelectListItem(){Text = "C++", Value="C++"},
                new SelectListItem(){Text = "C#", Value="C#"},
                new SelectListItem(){Text = "Java", Value="Java"},
                new SelectListItem(){Text = "C", Value="C"},
                new SelectListItem(){Text = "Python", Value="Python"},
                new SelectListItem(){Text = "Objective C", Value="Objective C"},
                new SelectListItem(){Text = "SQL", Value="SQL"},
                new SelectListItem(){Text = "Javascript", Value="Javascript"},
                new SelectListItem(){Text = "Ruby", Value="Ruby"},
                new SelectListItem(){Text = "Perl", Value="Perl"},
                new SelectListItem(){Text = "ActionScript", Value="ActionScript"},
                new SelectListItem(){Text = "Visual Basic", Value="Visual Basic"},
                new SelectListItem(){Text = "Lisp", Value="Lisp"},
                new SelectListItem(){Text = "Assembly", Value="Assembly"},
                new SelectListItem(){Text = "Scala", Value="Scala"},
                new SelectListItem(){Text = "Arduino", Value="Arduino"},
            };
            ViewBag.Education = new List<SelectListItem>()

            {
                new SelectListItem(){Text = "Associate degree", Value="Associate degree"},
                new SelectListItem(){Text = "Bachelor's degree", Value="Bachelor degree"},
                new SelectListItem(){Text = "Master's degree", Value="Master degree"},
                new SelectListItem(){Text = "Doctoral degree", Value="Doctoral degree"},

            };
            User user = mapper.Fetch<User>("SELECT * FROM opportunity.user where email='" + GetLoggedUser(null) + "' ").FirstOrDefault();
            return View(user);
        }
        [HttpPost]
        public IActionResult EditUser(User user)
        {
            session.Execute(" DELETE skills FROM  opportunity.user WHERE email= '" + user.Email + "'  ");
            if (user.Skills != null)
            {
                foreach (var item in user.Skills)
                    session.Execute("update opportunity.user set skills = skills + {'" + item + "'} where email= '" + user.Email + "' ");
            }
            session.Execute("UPDATE opportunity.user SET fname = '" + user.FName + "', lname ='" + user.LName + "', description='" + user.Description + "', education='"+user.Education+"' , location='" + user.Location + "'  WHERE email= '" + user.Email + "'  ");
            return RedirectToAction("UserProfile");
        }

        [HttpPost]
        public IActionResult  AddMoreInfo(User u, string email)
        {
            GetLoggedUser(email);
                foreach (var skill in u.Skills)
                    session.Execute("UPDATE opportunity.user SET skills = skills + {'" + skill + "'}   WHERE email = '" + LoggedUser + "'");

            session.Execute("UPDATE opportunity.user SET description = '" + u.Description + "', location='" + u.Location + "', education='"+u.Education+"' where email='" + LoggedUser + "' ");



            ViewBag.Skills = new List<SelectListItem>()

            {
                new SelectListItem(){Text = "C++", Value="C++"},
                new SelectListItem(){Text = "C#", Value="C#"},
                new SelectListItem(){Text = "Java", Value="Java"},
                new SelectListItem(){Text = "C", Value="C"},
                new SelectListItem(){Text = "Python", Value="Python"},
                new SelectListItem(){Text = "Objective C", Value="Objective C"},
                new SelectListItem(){Text = "SQL", Value="SQL"},
                new SelectListItem(){Text = "Javascript", Value="Javascript"},
                new SelectListItem(){Text = "Ruby", Value="Ruby"},
                new SelectListItem(){Text = "Perl", Value="Perl"},
                new SelectListItem(){Text = "ActionScript", Value="ActionScript"},
                new SelectListItem(){Text = "Visual Basic", Value="Visual Basic"},
                new SelectListItem(){Text = "Lisp", Value="Lisp"},
                new SelectListItem(){Text = "Assembly", Value="Assembly"},
                new SelectListItem(){Text = "Scala", Value="Scala"},
                new SelectListItem(){Text = "Arduino", Value="Arduino"},
            };
            ViewBag.Education = new List<SelectListItem>()

            {
                new SelectListItem(){Text = "C++", Value="C++"},
                new SelectListItem(){Text = "C#", Value="C#"},
                new SelectListItem(){Text = "Java", Value="Java"},
                new SelectListItem(){Text = "C", Value="C"},
                new SelectListItem(){Text = "Python", Value="Python"},
                new SelectListItem(){Text = "Objective C", Value="Objective C"},
                new SelectListItem(){Text = "SQL", Value="SQL"},
                new SelectListItem(){Text = "Javascript", Value="Javascript"},
                new SelectListItem(){Text = "Ruby", Value="Ruby"},
                new SelectListItem(){Text = "Perl", Value="Perl"},
                new SelectListItem(){Text = "ActionScript", Value="ActionScript"},
                new SelectListItem(){Text = "Visual Basic", Value="Visual Basic"},
                new SelectListItem(){Text = "Lisp", Value="Lisp"},
                new SelectListItem(){Text = "Assembly", Value="Assembly"},
                new SelectListItem(){Text = "Scala", Value="Scala"},
                new SelectListItem(){Text = "Arduino", Value="Arduino"},

            };
            return RedirectToAction("UserSignedIn", new { email=email});

        }
        public IActionResult SaveAd(Guid idad, string typeofjob)
        {
            session.Execute("UPDATE opportunity.user SET adsaved = adsaved + {"+ idad + " : '" + typeofjob + "'}   WHERE email = '" + GetLoggedUser(null) + "'");
            return RedirectToAction("AdProfile", new { idAd= idad, typeofjob= typeofjob });
        }
        public IActionResult GetSavedAds()
        {
            User u  = mapper.Fetch<User>("SELECT * from opportunity.user where email='" + LoggedUser + "'").FirstOrDefault();
            IDictionary<Guid, String> savedAds = u.AdSaved;
            return View(savedAds); 
        }
        public IActionResult RemoveSavedAd(Guid idAd , string typeofjob)
        {
            session.Execute("DELETE adsaved["+idAd+"] FROM opportunity.user WHERE email = '" + LoggedUser + "';");
            return RedirectToAction("GetSavedAds");
        }
        public IActionResult AdHistory()
        {
            session.Execute("UPDATE opportunity.user_by_ad SET adhistory = adhistory + {toTimestamp(now()) : 1599c2be-b40b-4fac-84d9-2ca5ed77e0ee } WHERE email = '" + LoggedUser + "';");
            return View();
        }
        [HttpGet]
        public IActionResult ApplyToAd(Guid idAd, string typeofjob)
        {
            TempData["EmailUser"] = GetLoggedUser(null);
            
            Ad ad = mapper.Fetch<Ad>("SELECT * FROM ad WHERE typeofjob='" + typeofjob + "' and idad=" + idAd + "").FirstOrDefault();
            var row = session.Execute("SELECT nameoffirm from opportunity.firm where email='" + ad.EmailFirm + "'").FirstOrDefault();
            string nameOfFirm = row.GetValue<string>("nameoffirm");
            TempData["NameOfFirm"] = nameOfFirm;
            ViewBag.nameoffirm = nameOfFirm;
            ViewBag.loggeduser = GetLoggedUser(null);
            return View(ad);
        }

        [HttpPost]
        public IActionResult ApplyToAd(IFormFile files, Ad ad)
        {
            ViewBag.nameoffirm = TempData["NameOfFirm"].ToString();
            ViewBag.loggeduser = GetLoggedUser(null);

            if (files != null)
            {
                if (files.Length > 0)
                {

                    var fileName = Path.GetFileName(files.FileName);

                    var myUniqueFileName = GetLoggedUser(null) +""+ ad.IdAd.ToString();

                    var fileExtension = Path.GetExtension(fileName);

                    var newFileName = String.Concat(myUniqueFileName, fileExtension);

                    var filepath =
                    new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Files")).Root + $@"\{newFileName}";

                    using (FileStream fs = System.IO.File.Create(filepath))
                    {
                        files.CopyTo(fs);
                        fs.Flush();
                    }
                    session.Execute("insert into opportunity.ads_user_applied (email,idad,time,typeofjob) values ('" + GetLoggedUser(null) + "'," + ad.IdAd + ", toTimestamp(now()), '" + ad.TypeOfJob + "' )");
                    User u = mapper.Fetch<User>("select fname,lname from opportunity.user where email='" + GetLoggedUser(null) + "'").FirstOrDefault();
                    session.Execute("insert into opportunity.firm_applied_users (idad,email,fname,lname,typeofjob,time,cvpath) values (" + ad.IdAd + ", '" + GetLoggedUser(null) + "', '" + u.FName + "','" + u.LName + "', '" + ad.TypeOfJob + "',toTimestamp(now()), '" + filepath + "')");
                }
                

                return RedirectToAction("UserProfile");
            }
             
            return View(ad);

        }
        public IActionResult GetAppliedAds()
        {
            List<Ads_user_applied> appliedAds = mapper.Fetch<Ads_user_applied>("SELECT * FROM ads_user_applied WHERE email='" + GetLoggedUser(null) + "'").ToList();
            
            return View(appliedAds);
        }
       
        public IActionResult GetAdsSortedByTime()
        {
            List<Ad> ads = mapper.Fetch<Ad>("SELECT * from ad").ToList();
            return View(ads);
        }
        public IActionResult LogoutUser()
        {
            LoggedUser = null;
            return RedirectToAction("Index", "Home");
        }
        
         
    }
    
}
