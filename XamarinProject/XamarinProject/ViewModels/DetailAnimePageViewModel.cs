using System;
using System.Collections.Generic;
using System.Text;
using XamarinProject.Models;

namespace XamarinProject.ViewModels
{
    class DetailAnimePageViewModel : BaseViewModel
    {
        private Anime anime;

        public DetailAnimePageViewModel(Anime anime)
        {
            CurrentAnime = anime;
            Titre = "Détail de l'anime";
        }

        private Anime currentAnime;
        public Anime CurrentAnime
        {
            get { return currentAnime; }
            set
            {
                currentAnime = value;
                OnPropertyChanged();
            }
        }
    }
}
