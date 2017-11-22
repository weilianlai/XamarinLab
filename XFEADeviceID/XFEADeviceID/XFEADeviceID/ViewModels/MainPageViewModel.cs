using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using XFEADeviceID.Interfaces;

namespace XFEADeviceID.ViewModels
{

    public class MainPageViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Title { get; set; }
        public string DeviceID { get; set; }
        public string DispalyID { get; set; }

        IGetDeviceID _getDeviceID;

        private readonly INavigationService _navigationService;

        public MainPageViewModel(INavigationService navigationService, IGetDeviceID deviceID)
        {
            _navigationService = navigationService;
            _getDeviceID = deviceID;
            DispalyID = _getDeviceID.GetDeviceID();
            Title = "取得手機裝置唯一ID";
            DeviceID = "此手機裝置唯一的設備ID是：";
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
