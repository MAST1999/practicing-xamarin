using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TravelRecordApp
{
    public partial class MainPage : ContentPage
    {
    public Thickness MainPadding = new Thickness(2);
        public MainPage()
        {
            InitializeComponent();
        }

        private void LoginButton_Clicked(object sender, EventArgs e)
        {
            bool errors = false;

            if (string.IsNullOrEmpty(EmailEntry.Text))
            {
                errors = true;
                EmailLabel.Text = "Please enter your email address";
            } else
            {
                EmailLabel.Text = "";
            }

            if (string.IsNullOrEmpty(PasswordEntry.Text))
            {
                errors = true;
                PasswordLabel.Text = "Please enter your password";
            } else
            {
                PasswordLabel.Text = "";
            }

            if (errors) return;

            Navigation.PushAsync(new HomePage());
        }
    }
}
