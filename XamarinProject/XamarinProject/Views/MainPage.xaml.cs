using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinProject.Models;
using XamarinProject.ViewModels;
using XamarinProject.Views;

namespace XamarinProject
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = new MainPageViewModel();

            animesListView.ItemTapped += animesListView_ItemTapped;
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

        private void animesListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            try
            {
                ((MainPageViewModel)BindingContext).DetailAnimePage = null;
                Anime selectedSample = (Anime)e.Item;
                Navigation.PushAsync(new DetailAnimePage(selectedSample), true);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Something is thrown ! " + ex.ToString());
            }
        }
    }
}
