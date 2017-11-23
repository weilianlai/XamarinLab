using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace XFAppFlow.ViewModels
{

    public class NaviPreferPageViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly INavigationService _navigationService;
        public DelegateCommand ThemeCommand { get; set; }

        public NaviPreferPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            ThemeCommand = new DelegateCommand(async () =>
            {
                var foopara = new NavigationParameters();
                foopara.Add("Data", "Come from NaviPage");
                await _navigationService.NavigateAsync("ThemePage", foopara);
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
