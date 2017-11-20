using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace XFNaviPara.ViewModels
{


    public class NextPageViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string MyName { get; set; }
        public string MyAccount { get; set; }

        public DelegateCommand GoBackCommand { get; set; }


        private readonly INavigationService _navigationService;

        public NextPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            _navigationService.GoBackAsync();

        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey(nameof(MyName)))
            {
                MyName = parameters[nameof(MyName)] as string;
            }
            if (parameters.ContainsKey(nameof(MyAccount)))
            {
                MyName = parameters[nameof(MyAccount)] as string;
            }
        }

    }

}
