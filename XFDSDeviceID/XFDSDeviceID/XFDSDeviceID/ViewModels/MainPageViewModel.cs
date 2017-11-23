using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using XFDSDeviceID.Interfaces;

namespace XFDSDeviceID.ViewModels
{

    public class MainPageViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly INavigationService _navigationService;
        public string DeviceID { get; set; }
        public string DispalyID { get; set; }
        public string Title { get; set; }

        IGetDeviceID _getDeviceID;

        public MainPageViewModel(INavigationService navigationService, IGetDeviceID getDeviceID)
        {
            _navigationService = navigationService;
            _getDeviceID = getDeviceID;
            DispalyID = _getDeviceID.GetDeviceID();

            Title = "取得手機裝置唯一ID";
            DeviceID = "此裝置唯一的設備ID是：";
            
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
