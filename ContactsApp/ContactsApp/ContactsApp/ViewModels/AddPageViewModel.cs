using ContactsApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ContactsApp.ViewModels
{
    public class AddPageViewModel : INotifyPropertyChanged
    {
        public ICommand AddContactCommand { get; set; }
        Contact _contactSelected;
        public Contact ContactSelected
        {
            get
            {
                return _contactSelected;
            }
            set
            {
                _contactSelected = value;
            }
        }
        public AddPageViewModel(ObservableCollection<Contact> contacts)
        {
            AddContactCommand = new Command<Contact>((param) =>
            {
                Contacts.Add(new Contact() { Name = ContactSelected.Name, Number = ContactSelected.Number });

            });
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
