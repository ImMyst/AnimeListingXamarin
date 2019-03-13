using System;
using System.Collections.Generic;
using System.Text;
using XamarinProject.Models;

namespace XamarinProject.ViewModels
{
    class MainPageViewModel : BaseViewModel
    {
        public MainPageViewModel()
        {
            Titre = "MyAniList";
        }
        private List<Anime> listAnimes;
        public List<Anime> ListAnimes
        {
            get
            {
                return listAnimes;
            }
            set
            {
                listAnimes = value;
                OnPropertyChanged("ListAnimes");
            }
        }

        private Anime selectedAnime;
        public Anime SelectedAnime
        {
            get
            {
                return selectedAnime;
            }
            set
            {
                selectedAnime = value;
                OnPropertyChanged();
            }
        }

        public object DetailAnimePage { get; internal set; }
    }
}
