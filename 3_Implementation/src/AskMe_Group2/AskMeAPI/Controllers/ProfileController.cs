using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AskMeDTO;
using AskMeBL;
using AskMeAPI.Models;

namespace AskMeAPI.Controllers
{
    public class ProfileController : Controller
    {
            ProfileBL blObj;

        public ActionResult GetAllProfile()
        {
            List<Models.Profile> resultList = new List<Models.Profile>();
            blObj = new ProfileBL();
            var result = blObj.GetAllProfile();
            foreach (var item in result)
            {
                resultList.Add(new Models.Profile
                {
                    UserId = item.UserId,
                    UserName = item.UserName,
                    UEmail = item.UEmail,
                    UAge = item.UAge
                });
            }

            return View(resultList);
        }

        // GET: Profile
        public ActionResult GetProfile(string userName)
        {
                List<Models.Profile> resultList = new List<Models.Profile>();
                blObj = new ProfileBL();
                var result = blObj.GetProfile(userName);
                foreach (var item in result)
                {
                    resultList.Add(new Models.Profile
                    {
                        UserId = item.UserId,
                        UserName = item.UserName,
                        UEmail = item.UEmail,
                        UAge = item.UAge
                    });
                }

                return View(resultList);
        }

        [HttpGet]
        public ActionResult AddProfile()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddProfile(Profile obj)
        {
            blObj = new ProfileBL();
            ProfileDTO profile = new ProfileDTO { UserName=obj.UserName,UEmail=obj.UEmail,UAge=obj.UAge };
            int result = blObj.AddProfile(profile);
            if (result == 1)
            {
                return Redirect("GetAllProfile");
            }
            else
            {
                return View("Error");
            }

        }
    }
}
