using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelRecordApp.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TravelRecordApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewTravelPage : ContentPage
    {
        public NewTravelPage()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Post post = new Post
            {
                Experience = experianceEntry.Text,
            };

            SQLiteConnection connection = new SQLiteConnection(App.DatabaseLocation);
            connection.CreateTable<Post>();

            int rows = connection.Insert(post);
            if (rows > 0)
            {
                DisplayAlert("Success", "Experiance successfully inserted", "Ok");
            }
            else
            {
                DisplayAlert("Failure", "Failed to save the experiance", "Ok");
            }
            connection.Close();
        }
    }
}