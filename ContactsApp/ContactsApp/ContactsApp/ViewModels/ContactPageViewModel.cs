using ContactsApp.Models;
using ContactsApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ContactsApp.ViewModels
{
    public class ContactPageViewModel : INotifyPropertyChanged
    {        
        public ObservableCollection<Contact> Contacts { get; set; } = new ObservableCollection<Contact>();
        public ICommand GoToAddCommand { get; set; }
        Contact _contactSelected; 
        public Contact ContactSelected { get
            {
                return _contactSelected;
            }
            set
            {
                _contactSelected = value;
                if(_contactSelected != null)
                {
                    
                }
            }
        }
            
        public ICommand AddContactCommand { get; set; }
        public ContactPageViewModel()
        {
            Contacts.Add(new Contact() { Name = "Jose", Number = "8099860892" });
            GoToAddCommand = new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PushAsync(new AddPage());
            });

            AddContactCommand = new Command<Contact>((param) =>
            {
                Contacts.Add(new Contact() { Name = ContactSelected.Name, Number = ContactSelected.Number });
            });
        }                      
        
        public void AddContact()
        {
            Contacts.Add(new Contact() { Name = ContactSelected.Name, Number = ContactSelected.Number});
        }

        async void DisplayElementSelected()
        {
            await App.Current.MainPage.Navigation.PushAsync(new MainPage());
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
