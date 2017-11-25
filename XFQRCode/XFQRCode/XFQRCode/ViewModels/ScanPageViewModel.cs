using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Xamarin.Forms;
using ZXing;

namespace XFQRCode.ViewModels
{

    public class ScanPageViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly INavigationService _navigationService;
        public bool IsAnalyzing { get; set; }
        public bool IsScanning { get; set; }
        public Result ScanResult { get; set; }

        public DelegateCommand ScanResultCommand { get; set; }


        public ScanPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            ScanResultCommand = new DelegateCommand(async () =>
            {
                Device.BeginInvokeOnMainThread(async() => 
                {
                    IsAnalyzing = false;
                    IsScanning = false;
                    var fooPara = new NavigationParameters();
                    fooPara.Add("Result", ScanResult);
                    await navigationService.GoBackToRootAsync(fooPara);


                });
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
