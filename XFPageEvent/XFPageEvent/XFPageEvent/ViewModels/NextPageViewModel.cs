using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace XFPageEvent.ViewModels
{


    public class NextPageViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string MyEntry { get; set; }

        public DelegateCommand GoBackCommand { get; set; }

        private readonly INavigationService _navigationService;

        public NextPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            GoBackCommand = new DelegateCommand(()=> 
            {

            }
            );

        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {

        }

    }

}
