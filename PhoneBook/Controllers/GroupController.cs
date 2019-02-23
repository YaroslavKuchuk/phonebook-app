using PhoneBook.Models;
using PhoneBook.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace PhoneBook.Controllers
{
    public class GroupController : Controller
    {

        private IGroupApiService _groupApiService = new GroupApiServices();

        ContactContext db = new ContactContext();
        // GET: Group


        public async Task<ActionResult> List()
        {
            //IEnumerable<Groups> groups = db.Groups;
            var groupsList = await _groupApiService.Getlist();
           // groupsList = db.Groups;
            return View(groupsList); 
        }
        [AllowAnonymous]
        public ActionResult Additional()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Additional(Groups group)
        {
            
            if (!ModelState.IsValid)
                return View(group);

            db.Groups.Add(group);
            db.SaveChanges();
            return RedirectToAction("List");            
        }

        public ActionResult Delete(int? id)
        {
            Groups group = db.Groups.Find(id);

            if (group != null)
            {
                db.Groups.Remove(group);
                db.SaveChanges();
            }

            return RedirectToAction("List");

        }
        public ActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Update(int? Id, Groups model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }
            Groups group = db.Groups.Find(Id);
            db.Groups.Remove(group);
            db.Groups.Add(model);

            db.SaveChanges();

            return RedirectToAction("List");

        }

    }
}