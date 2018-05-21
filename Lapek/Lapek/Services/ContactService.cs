using Lapek.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lapek.Services
{
    public class ContactService
    {
        public ContactModel GetContact()
        {
            var contact = new ContactModel
            {
                Address = "ul. Zwyczajna 9/11 \n 42-200 Częstochowa",
                Email = "kontakt@lapek.pl",
                Phone = "+48 111 222 333",
                OpeningHours = "Pn.-Pt.: 9.00-17.00",
                Facebook = "facebook.png",
                Twitter = "twitter.png",
                LinkedIn = "linkedin.png"
            };
            return contact;
        }
    }
}
