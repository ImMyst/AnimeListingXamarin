using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinProject.Models;

namespace XamarinProject
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            using(SQLite.SQLiteConnection connection = new SQLite.SQLiteConnection(App.DB_PATH))
            {
                connection.CreateTable<Anime>();
                var animes = connection.Table<Anime>().ToList();
                animesListView.ItemsSource = animes;
            }
        }

        private void navigationActivated(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewAnimePage());
        }
    }
}
