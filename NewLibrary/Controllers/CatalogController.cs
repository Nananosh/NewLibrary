using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NewLibrary.DataBaseConnection;
using NewLibrary.DataBaseConnection.Factory;
using NewLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewLibrary.Controllers
{
    public class CatalogController : Controller
    {
        [HttpGet]
        [Authorize]
        public IActionResult MyReceived()
        {
            
            string t = "";
            foreach (var x in User.Claims)
            {
                if (x.Value != null)
                {
                    t = x.Value;
                    break;
                }


            }
            var users = Factory.GetAllProfiles(DatabaseConnection.GetAllProfiles());
            foreach (Profile user in users)
            {
                if (user.Id == Convert.ToInt32(t))
                {
                    ViewBag.User = user;
                    break;
                }
            }
            
            var myceived = Factory.GetReceived(DatabaseConnection.GetReceived(Convert.ToInt32(t)));

            ViewBag.ReceivedUser = myceived;
            return View();

        }
        [HttpPost]
        public IActionResult MyReceived(int user, int pubid)
        {
            Factory.RemoveFromReceived(user, pubid);
            return Redirect("/Catalog/MyReceived");
        }
        public IActionResult More(int id)
        {
            var allpubl= Factory.GetAllPublication2(DatabaseConnection.GetAllPublication2());
            ViewBag.BookId = id;
            var ff = Factory.GetAllRental(DatabaseConnection.GetAllRental());

            foreach (PublicationInformation pub in allpubl)
            {
                
                if (pub.Id == id)
                {
                    if (ff.Count > 0)
                    {
                        ViewBag.State = Factory.GetPublicationRent(DatabaseConnection.GetPublicationRent(pub.Id));
                        ViewBag.Obj = pub;
                        break;
                    }
                    else
                    {
                        ViewBag.State = 0;
                        ViewBag.Obj = pub;
                        break;
                    }
                    
                }
            }
            return View();
        }
        [HttpPost]
        public IActionResult More(Profile prof, int t)
        {
            var rentarlist = Factory.GetAllRental(DatabaseConnection.GetAllRental());
            DateTime Buy = DateTime.Now;
            foreach(Received item in rentarlist)
            {
                if (prof.Id == item.Profile_Id && item.Publication_Id == t)
                    Factory.SetRental1(prof.Id, t);

                   
            }
            Factory.AddRental(prof.Id, t, Buy);
            return Redirect("/Catalog/AllCatalog");
          
        }
        
        public IActionResult AllCatalog()
        {
            var alltovars = Factory.GetAllPublication2(DatabaseConnection.GetAllPublication2());
            ViewBag.AllTovars = alltovars;
            
            return View();
        }
    }
}
