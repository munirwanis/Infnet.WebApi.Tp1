using Infnet.WebApi.Tp1.Business;
using Infnet.WebApi.Tp1.Presentation.Mapper;
using System.Web.Mvc;

namespace Infnet.WebApi.Tp1.Presentation.Controllers
{
    public class ContactController : Controller
    {
        private readonly Manager _manager;
        public ContactController()
        {
            this._manager = new Manager();
        }
        // GET: Contact
        public ActionResult Index()
        {
            var contacts = this._manager.GetContacts();
            var contactsView = ContactMapper.MapContactView(contacts);
            return View(contactsView);
        }

        // GET: Contact/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
