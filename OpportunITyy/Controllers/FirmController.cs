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

namespace OpportunITyy.Controllers
{
    public class FirmController : Controller
    {
        public static string LoggedFirm {get; set;}
        readonly ISession session = SessionManager.GetSession();
        readonly IMapper mapper = new Mapper(SessionManager.GetSession());
        private static object objLock = new object();
        public static string GetLoggedFirm(string email)
        {

            if (LoggedFirm == null)
            {
                lock (objLock)
                {
                    if (LoggedFirm == null)
                    {
                        LoggedFirm = email;
                    }
                }
            }

            return LoggedFirm;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult FirmSignedIn(string email, string typeofjob)
        {
            ViewBag.Email = email;
            GetLoggedFirm(email);
           

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
        public IActionResult FirmProfile()
        {
            Firm firm = mapper.Fetch<Firm>("SELECT * FROM firm WHERE email='" + GetLoggedFirm(null) + "'").FirstOrDefault();
            return View(firm);
        }
        [HttpGet]
        public IActionResult AddAd()
        {
            ViewBag.Technologies = new List<SelectListItem>()

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
            ViewBag.TypeOfJob = new List<SelectListItem>()

            {
                new SelectListItem(){Text = "Programming", Value="Programming"},
                new SelectListItem(){Text = "System administration", Value="System administration"},
                new SelectListItem(){Text = "Management", Value="Management"},
                new SelectListItem(){Text = "UX designer", Value="UX designer"},
                new SelectListItem(){Text = "Support", Value="Support"},
                new SelectListItem(){Text = "Selling/Adviser", Value="Adviser"},
                new SelectListItem(){Text = "Practice", Value="Practice"},

            };
            ViewBag.Seniority = new List<SelectListItem>()
            {
                new SelectListItem(){Text = "Junior", Value="Junior"},
                new SelectListItem(){Text = "Middle", Value="Middle"},
                new SelectListItem(){Text = "Senior", Value="Senior"},
            };
            ViewBag.TypeOfWork = new List<SelectListItem>()
            {
                new SelectListItem(){Text = "Remote", Value="Remote"},
                new SelectListItem(){Text = "At office", Value="At office"},

            };
            return View();
        }
        [HttpPost]
        public IActionResult AddAd(Ad ad)
        {
            if (ad.Seniority != null && ad.Technologies != null & ad.TypeOfJob != null)
            {
                ad.EmailFirm = GetLoggedFirm(null);
                ad.IdAd = Guid.NewGuid();
                ad.ActiveStatus = true;
                long d = DateTimeOffset.Now.ToUnixTimeMilliseconds();

                session.Execute("insert into opportunity.ad (onlineinterview, emailfirm,idad,typeofjob,activestatus,adsetted,city,description,seniority,typeofwork) values (" + ad.OnlineInterView + ", '" + ad.EmailFirm + "', " + ad.IdAd + ", '" + ad.TypeOfJob + "', true,"+d+", '" + ad.City + "', '" + ad.Description + "','" + ad.Seniority + "', '" + ad.TypeOfWork + "')");
                foreach (var item in ad.Technologies)
                    session.Execute("update opportunity.ad set technologies = technologies + {'" + item + "'} where typeofjob= '" + ad.TypeOfJob + "' and idad=" + ad.IdAd + "");
                session.Execute("insert into opportunity.ads_by_firm (email,time,idad,typeofjob) values ('" + ad.EmailFirm + "',"+d+" , " + ad.IdAd + ", '" + ad.TypeOfJob + "' )");
                return RedirectToAction("FirmProfile");
            }
            else
            {
                ViewBag.Technologies = new List<SelectListItem>()

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
                ViewBag.TypeOfJob = new List<SelectListItem>()

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
                ViewBag.Seniority = new List<SelectListItem>()
            {
                new SelectListItem(){Text = "Junior", Value="Junior"},
                new SelectListItem(){Text = "Middle", Value="Middle"},
                new SelectListItem(){Text = "Senior", Value="Senior"},
            };
                ViewBag.TypeOfWork = new List<SelectListItem>()
            {
                new SelectListItem(){Text = "Remote", Value="Remote"},
                new SelectListItem(){Text = "At office", Value="At office"},

            };
                return View(ad);
            }
        }
        public IActionResult AdProfile(Guid idAd, string typeofJob, string email)
        {
            ViewBag.emailOfFirm = GetLoggedFirm(null) ;

            Ad ad = mapper.Fetch<Ad>("SELECT * from opportunity.ad where typeofjob='" + typeofJob + "' AND idad = " + idAd + "").FirstOrDefault();
        
            List<Firm_applied_users> appliedUsers = mapper.Fetch<Firm_applied_users>("SELECT * from firm_applied_users where idad=" + ad.IdAd + "").ToList();
            ad.AppliedUsers = appliedUsers;

            return View(ad);

        }
        [HttpGet]
        public IActionResult EditAd(Guid idAd, string typeofJob)
        {
            TempData["OldType"] = typeofJob;
            ViewBag.Technologies = new List<SelectListItem>()

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
            ViewBag.TypeOfJob = new List<SelectListItem>()

            {
                new SelectListItem(){Text = "Programming", Value="Programming"},
                new SelectListItem(){Text = "System administration", Value="System administration"},
                new SelectListItem(){Text = "Management", Value="Management"},
                new SelectListItem(){Text = "UX designer", Value="UX designer"},
                new SelectListItem(){Text = "Support", Value="Support"},
                new SelectListItem(){Text = "Selling/Adviser", Value="Adviser"},
                new SelectListItem(){Text = "Practice", Value="Practice"},

            };
            ViewBag.Seniority = new List<SelectListItem>()
            {
                new SelectListItem(){Text = "Junior", Value="Junior"},
                new SelectListItem(){Text = "Middle", Value="Middle"},
                new SelectListItem(){Text = "Senior", Value="Senior"},
            };
            ViewBag.TypeOfWork = new List<SelectListItem>()
            {
                new SelectListItem(){Text = "Remote", Value="Remote"},
                new SelectListItem(){Text = "At office", Value="At office"},

            };
            Ad ad = mapper.Fetch<Ad>("SELECT * FROM ad where typeofjob='" + typeofJob + "' AND idad=" + idAd + "").FirstOrDefault();
            return View(ad);
        }
        [HttpPost]
        public IActionResult EditAd(Guid idAd, string typeofJob, Ad ad)
        {
            if (ad.Seniority != null && ad.Technologies != null & ad.TypeOfJob != null)
            {

                string oldtype = TempData["OldType"].ToString();
                if (oldtype == ad.TypeOfJob)
                {
                    session.Execute(" DELETE technologies FROM  opportunity.ad WHERE typeofjob= '" + typeofJob + "'  AND idAd = " + idAd + " ");
                    
                    if (ad.Technologies != null)
                    {
                        
                        
                        foreach (var item in ad.Technologies)
                            session.Execute("update opportunity.ad set technologies = technologies + {'" + item + "'} where typeofjob= '" + ad.TypeOfJob + "' and idad=" + ad.IdAd + "");
                    }
                    session.Execute("UPDATE opportunity.ad SET description = '" + ad.Description + "', city ='" + ad.City + "', seniority='" + ad.Seniority + "' ,onlineinterview=" + ad.OnlineInterView + " , typeofwork ='" + ad.TypeOfWork + "'  WHERE typeofjob= '" + typeofJob + "'  AND idAd = " + idAd + "  ");
                    return RedirectToAction("SeePublishedAds");
                }
                else
                {
           

                    session.Execute(" DELETE  FROM  opportunity.ad WHERE typeofjob= '" + oldtype + "'  AND idAd = " + idAd + " ");

                    session.Execute("insert into opportunity.ad (onlineinterview, emailfirm,idad,typeofjob,activestatus,adsetted,city,description,seniority,typeofwork) values (" + ad.OnlineInterView + ", '" + ad.EmailFirm + "', " + ad.IdAd + ", '" + ad.TypeOfJob + "', true ,toTimestamp(now()), '" + ad.City + "', '" + ad.Description + "','" + ad.Seniority + "', '" + ad.TypeOfWork + "')");
                    if (ad.Technologies != null)
                    {
                        foreach (var item in ad.Technologies)
                            session.Execute("update opportunity.ad set technologies = technologies + {'" + item + "'} where typeofjob= '" + ad.TypeOfJob + "' and idad=" + ad.IdAd + "");
                    }
                    session.Execute(" UPDATE opportunity.ads_by_firm SET typeofjob= '" + ad.TypeOfJob + "' WHERE email= '" + ad.EmailFirm + "'  AND idAd = " + idAd + " ");
                    return RedirectToAction("SeePublishedAds");
                }
            }
            else
            {
                ViewBag.Technologies = new List<SelectListItem>()

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
                ViewBag.TypeOfJob = new List<SelectListItem>()

            {
                new SelectListItem(){Text = "Programming", Value="Programming"},
                new SelectListItem(){Text = "System administration", Value="System administration"},
                new SelectListItem(){Text = "Management", Value="Management"},
                new SelectListItem(){Text = "UX designer", Value="UX designer"},
                new SelectListItem(){Text = "Support", Value="Support"},
                new SelectListItem(){Text = "Selling/Adviser", Value="Adviser"},
                new SelectListItem(){Text = "Practice", Value="Practice"},

            };
                ViewBag.Seniority = new List<SelectListItem>()
            {
                new SelectListItem(){Text = "Junior", Value="Junior"},
                new SelectListItem(){Text = "Middle", Value="Middle"},
                new SelectListItem(){Text = "Senior", Value="Senior"},
            };
                ViewBag.TypeOfWork = new List<SelectListItem>()
            {
                new SelectListItem(){Text = "Remote", Value="Remote"},
                new SelectListItem(){Text = "At office", Value="At office"},

            };
                return View(ad);
            }
       

            
        }
        public IActionResult UserProfile(string email)
        {

            User user = mapper.Fetch<User>("SELECT * FROM user WHERE email='" + email + "'").FirstOrDefault();
            
            return View(user);
        }

        public IActionResult DeleteAd(Guid idAd, string typeofJob, string email, DateTimeOffset time)
        {
             
            
            session.Execute("DELETE FROM opportunity.ad where typeofjob= '" + typeofJob + "' and idad=" + idAd + " ");

            
            session.Execute("DELETE FROM opportunity.ads_by_firm where email= '" + email + "' and idad= "+idAd+"");
            return RedirectToAction("SeePublishedAds");
        }
        public IActionResult SeePublishedAds()
        {
            ViewBag.Email = GetLoggedFirm(null);
            List<Ads_by_firm> ads = mapper.Fetch<Ads_by_firm>("SELECT * from ads_by_firm where email='" + GetLoggedFirm(null) + "'").ToList();
            IOrderedEnumerable<Ads_by_firm> adsSorted =ads.OrderByDescending(item=>item.time);
            return View(adsSorted);
        }

        [HttpGet]
        public IActionResult EditFirm()
        {
            Firm firm = mapper.Fetch<Firm>("SELECT * FROM opportunity.firm where email='" + GetLoggedFirm(null) + "' ").FirstOrDefault();
            return View(firm);
        }
        [HttpPost]
        public IActionResult EditFirm(Firm firm)
        {
            if (firm.NameOfFirm != null)
            {
                session.Execute("UPDATE opportunity.firm SET nameoffirm = '" + firm.NameOfFirm + "', description='" + firm.Description + "' , location='" + firm.Location + "'  WHERE email= '" + firm.Email + "'  ");
                return RedirectToAction("FirmProfile");
            }
            else
                return View(firm);
        }
        public IActionResult ViewCv(string cvpath)
        {
            Firm_applied_users obj = new Firm_applied_users { CvPath = cvpath};
            return View(obj);
        }

        [HttpGet]
        public IActionResult AddMoreInfoFirm(string email)
        {
            LoggedFirm = email;
            return View();
        }
        [HttpPost]
        public IActionResult AddMoreInfoFirm(Firm f)
        {
            session.Execute("UPDATE opportunity.firm SET description = '" + f.Description + "', location='" + f.Location + "', nameoffirm='"+f.NameOfFirm+"' where email='"+ GetLoggedFirm(null) + "' ");
            return RedirectToAction("FirmSignedIn", new { email= GetLoggedFirm(null) });      
        
        }
        public IActionResult LogoutFirm()
        {
            LoggedFirm = null;
            return RedirectToAction("Index", "Home");
        }
    }
}
