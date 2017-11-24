using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace XFEADeviceID.ViewModels
{

    public class MainPageViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly INavigationService _navigationService;

        public string DeviceID { get; set; }

        public DelegateCommand GetDeviceIDCommand { get; set; }


        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            GetDeviceIDCommand = new DelegateCommand(()=> 
            {
                DeviceID = "123";
            });

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
