using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace XFAppFlow.ViewModels
{

    public class MenuPageViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public DelegateCommand HomeCommand { get; set; }
        public DelegateCommand PersonalInfoCommand { get; set; }
        public DelegateCommand SetupCommand { get; set; }
        public DelegateCommand LogoutCommand { get; set; }


        private readonly INavigationService _navigationService;

        public MenuPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            HomeCommand = new DelegateCommand(()=> 
            {
                _navigationService.NavigateAsync("xf:///MenuPage/NaviPage/MyPage");
            }
            );
            PersonalInfoCommand = new DelegateCommand(() =>
            {
                _navigationService.NavigateAsync("xf:///MenuPage/NaviPage/PersonalInfoPage");
            }
            );
            SetupCommand = new DelegateCommand(() =>
            {
                _navigationService.NavigateAsync("xf:///MenuPage/NaviPage/SetupPage");
            }
            );
            LogoutCommand = new DelegateCommand(() =>
            {
                _navigationService.NavigateAsync("MainPage");
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
