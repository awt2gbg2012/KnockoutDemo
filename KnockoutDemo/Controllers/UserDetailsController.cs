using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using KnockoutDemo.Models;

namespace KnockoutDemo.Controllers
{
    public class UserDetailsController : Controller
    {
        //
        // GET: /Person/

        [HttpPost]
        public JsonResult Save(UserDetailsModel userDetails)
        {
            // Faking Logic to save person to DB
            var message = string.Format("Saved {0} {1} {2}", userDetails.firstName, userDetails.lastName, userDetails.email);
            message += string.Format(" with {0} friends", userDetails.friends.Count);
            message += string.Format(" ({0} on twitter)", userDetails.friends.Where(s => s.isOnTwitter).Count());
            return Json(new { message });
        }

        [HttpGet]
        public JsonResult GetJSON()
        {
            // Logic to fetch person from DB
            var UserDetails = new UserDetailsModel
            {
                firstName = "BertS",
                lastName = "Smith",
                email = "bertie@smith.com",
                friends = new List<Friend> {
                                new Friend { 
                                    name = "SteveS", 
                                    isOnTwitter = false
                                }, 
                                new Friend { 
                                    name = "AnnieS", 
                                    isOnTwitter = true, 
                                    twitterHandle = "annie"
                                }
                            }
            };
            return Json(new JavaScriptSerializer().Serialize(UserDetails), JsonRequestBehavior.AllowGet);
        }

    }
}
