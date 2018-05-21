using Lapek.Models;
using Lapek.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Lapek.ViewModels
{
    public class ContactViewModel
    {
        public ContactModel Contact { get; set; }
        public ICommand TapCommandFacebook { get; set; }
        public ICommand TapCommandTwitter { get; set; }
        public ICommand TapCommandLinkedIn { get; set; }

        public ContactViewModel()
        {
            var contactSerices = new ContactService();
            Contact = contactSerices.GetContact();

            TapCommandFacebook = new Command(FacebookOnTapped);
            TapCommandTwitter = new Command(TwitterOnTapped);
            TapCommandLinkedIn = new Command(LinkedInOnTapped);
        }

        private void LinkedInOnTapped(object obj)
        {
            Device.OpenUri(new Uri("http://www.linkedin.com"));
        }

        private void TwitterOnTapped(object obj)
        {
            Device.OpenUri(new Uri("http://www.twitter.com"));
        }

        void FacebookOnTapped(object obj)
        {
           Device.OpenUri(new Uri("http://www.facebook.com"));
            
        }
        
    }
}
