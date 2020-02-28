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
        ObservableCollection<Contact> _contacts;
        public AddPageViewModel(ObservableCollection<Contact> contacts)
        {
            _contacts = contacts;
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
