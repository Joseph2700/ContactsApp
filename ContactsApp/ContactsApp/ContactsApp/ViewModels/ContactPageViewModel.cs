using ContactsApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ContactsApp.ViewModels
{
    public class ContactPageViewModel
    {
        public ObservableCollection<Contact> Contacts { get; set; } = new ObservableCollection<Contact>();

        public ContactPageViewModel()
        {
            Contacts.Add(new Contact() { Name = "Jose", Number = "8099860592" });
        }
    }
}
