using System;
using System.Collections.Generic;
using System.Text;

namespace AppCollectionViewContact.Models
{
   public class Contacts
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Telephone { get; set; }

        public string UserId { get; set; }

        public string Email { get; set; }

        public string Image { get; set; }

        public string Country { get; set; }

        public string FullName => FirstName + " " + LastName;
    }
}
