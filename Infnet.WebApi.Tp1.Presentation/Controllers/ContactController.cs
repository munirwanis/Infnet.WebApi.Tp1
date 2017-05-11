using Infnet.WebApi.Tp1.Business;
using Infnet.WebApi.Tp1.Presentation.Mapper;
using Infnet.WebApi.Tp1.Presentation.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Infnet.WebApi.Tp1.Presentation.Controllers
{
    public class ContactController : Controller
    {
        private readonly Manager _manager;
        private List<ContactViewModel> _contactsView;
        public ContactController()
        {
            this._manager = new Manager();
            var contacts = this._manager.GetContacts();
            this._contactsView = ContactMapper.MapContactView(contacts);
        }

        // GET: Contact
        public ActionResult Index() =>
            View(this._contactsView);

        public ActionResult ContactWithEmail()
        {
            if (TempData["Contacts"] == null)
            {
                TempData["Contacts"] = this._contactsView;
            }
            TempData.Keep();
            return View("ContactWithEmail", TempData["Contacts"]);
        }

        public ActionResult ContactWithPhone()
        {
            if (TempData["Contacts"] == null)
            {
                TempData["Contacts"] = this._contactsView;
            }
            TempData.Keep();
            return View("ContactWithPhone", TempData["Contacts"]);
        }

        // GET: Contact/Details/5
        public ActionResult Select(int id, string page)
        {
            var contacts = (List<ContactViewModel>)TempData["Contacts"];
            foreach (var c in contacts)
            {
                if (c.Id == id)
                {
                    if (c.Selected)
                    {
                        c.Selected = false;
                    }
                    else
                    {
                        c.Selected = true;
                    }
                }
            }
            TempData.Clear();
            TempData["Contacts"] = contacts;

            return RedirectToAction(page);
        }

        // GET: Contact/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contact/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Contact/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Contact/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Contact/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Contact/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
