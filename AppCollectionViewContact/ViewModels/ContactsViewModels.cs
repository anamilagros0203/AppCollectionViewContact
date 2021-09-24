using AppCollectionViewContact.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AppCollectionViewContact.ViewModels
{
    public class ContactsViewModel
    {
        public ObservableCollection<Contacts> contacts { get; set; }

        public ContactsViewModel()
        {
            contacts = new ObservableCollection<Contacts>
            {
                new Contacts{
                        FirstName = "Maria",
                        LastName = "Rojas",
                        Telephone = "(01) 987563487",
                        UserId="1",
                        Email="contact1@gmail.com",
                        Image="Woman.png",
                        Country="Peru"},
                new Contacts{
                        FirstName = "Jesus",
                        LastName = "Quispe",
                        Telephone = "(01) 987563487",
                        UserId="2",
                        Email="contact2@gmail.com",
                        Image="Man.png",
                        Country="Peru"},
                new Contacts{
                        FirstName = "Adrian",
                        LastName = "Muñoz",
                        Telephone = "(01) 987563487",
                        UserId="3",
                        Email="contact3@gmail.com",
                        Image="Man.png",
                        Country="Peru"},
                new Contacts{
                        FirstName = "Luciana",
                        LastName = "Magallanes",
                        Telephone = "(01) 987563487",
                        UserId="4",
                        Email="contact4@gmail.com",
                        Image="Woman.png",
                        Country="Peru"},
                new Contacts{
                        FirstName = "Derek",
                        LastName = "Lujan",
                        Telephone = "(01) 987563487",
                        UserId="5",
                        Email="contact5@gmail.com",
                        Image="Man.png",
                        Country="Peru"},

            };
        }
    }
}
