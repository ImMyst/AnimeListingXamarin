using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinProject.Models;

namespace XamarinProject
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NewAnimePage : ContentPage
	{
		public NewAnimePage ()
		{
			InitializeComponent ();
		}

        private void saveAnimeEntry(object sender, EventArgs e)
        {
            Anime anime = new Anime()
            {
                Name = nameEntry.Text,
                Studio = studioEntry.Text
            };

            using (SQLite.SQLiteConnection connection = new SQLite.SQLiteConnection(App.DB_PATH))
            {
                connection.CreateTable<Anime>();
                var numberRows = connection.Insert(anime);

                if (numberRows > 0)
                {
                    DisplayAlert("Bien joué !", "L'anime a bien été enregistré", "Continuer");
                }

                else

                {
                    DisplayAlert("Dommage", "L'anime n'a pas pu être enregistré", "Continuer");
                }
            }

    }
    }
}