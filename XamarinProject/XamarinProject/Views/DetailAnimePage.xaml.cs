using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinProject.Models;
using XamarinProject.ViewModels;

namespace XamarinProject.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailAnimePage : ContentPage
	{
        public DetailAnimePage(Anime anime)
        {
            InitializeComponent();
            BindingContext = new DetailAnimePageViewModel(anime);
        }
    }
}