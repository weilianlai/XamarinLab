using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace XFAppFlow.ViewModels
{

    public class SetupPageViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly INavigationService _navigationService;

        public DelegateCommand NaviPreferCommand { get; set; }

        public SetupPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NaviPreferCommand = new DelegateCommand(async ()=> 
            {
                var fooPara = new NavigationParameters();
                fooPara.Add("Data", "Come from SetupPage");
                await _navigationService.NavigateAsync("NaviPreferPage",fooPara);
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
