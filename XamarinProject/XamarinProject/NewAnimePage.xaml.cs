using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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
            DisplayAlert("Bien joué !", "L'anime a bien été enregistré", "Fermer");
        }
    }
}