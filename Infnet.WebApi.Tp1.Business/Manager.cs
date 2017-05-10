using Infnet.WebApi.Tp1.Data;
using Infnet.WebApi.Tp1.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Infnet.WebApi.Tp1.Business
{
    public class Manager
    {
        public Manager()
        {
            this.InsertContacts();
        }

        private readonly Context _db = new Context();
        public List<Contact> GetContacts() =>
            (from c in this._db.Contacts
             select c).ToList();

        private void InsertContacts()
        {
            var contacts = new List<Contact>
            {
                new Contact
                {
                    Email = "some@email.com",
                    FirstName = "Munir",
                    LastName = "Wanis",
                    PhoneNumber = "(21) 998 544 322"
                },
                new Contact
                {
                    Email = "some_other@email.com",
                    FirstName = "Robert",
                    LastName = "Crazy",
                    PhoneNumber = "(21) 958 324 322"
                },
                new Contact
                {
                    Email = "boring@email.com",
                    FirstName = "João",
                    LastName = "Gozo",
                    PhoneNumber = "(21) 555 566 666"
                },
                new Contact
                {
                    Email = "enough@email.com",
                    FirstName = "Whatever",
                    LastName = "Devil",
                    PhoneNumber = "(21) 666 666 666"
                }
            };

            var contactsInDb = this.GetContacts();

            foreach (var contact in contacts)
            {
                var contactInDb = contactsInDb.SingleOrDefault(c =>
                c.Email == contact.Email &&
                c.FirstName == contact.FirstName &&
                c.LastName == contact.LastName &&
                c.PhoneNumber == contact.PhoneNumber);

                if (contactInDb == null)
                {
                    this._db.Contacts.Add(contact);
                }
            }
            this._db.SaveChanges();
        }
    }
}
