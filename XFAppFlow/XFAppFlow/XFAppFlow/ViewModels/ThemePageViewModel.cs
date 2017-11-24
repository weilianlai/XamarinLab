using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace XFAppFlow.ViewModels
{

    public class ThemePageViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly INavigationService _navigationService;


        public DelegateCommand BackHomeCommand { get; set; }


        public ThemePageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            BackHomeCommand = new DelegateCommand(async()=> 
            {
                var fooPara = new NavigationParameters();   
                fooPara.Add("Data", "NaviPreferPage");
                await _navigationService.NavigateAsync("xf:///MenuPage/NaviPage/SetupPage", fooPara);
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
