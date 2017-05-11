using Infnet.WebApi.Tp1.Entities;
using Infnet.WebApi.Tp1.Presentation.Models;
using System.Collections.Generic;
using System.Linq;

namespace Infnet.WebApi.Tp1.Presentation.Mapper
{
    internal class ContactMapper
    {
        internal List<ContactViewModel> MapContactView(List<Contact> contacts) =>
            (from cs in contacts
             select new ContactViewModel
             {
                 Email = cs.Email,
                 FirstName = cs.FirstName,
                 Id = cs.Id,
                 LastName = cs.LastName,
                 PhoneNumber = cs.PhoneNumber
             }).ToList();
    }
}