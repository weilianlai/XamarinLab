using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using ZXing;

namespace XFQRCode.ViewModels
{

    public class MainPageViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string BarcodeFormatType { get; set; }
        public string BarcodeResult { get; set; }

        public DelegateCommand ScanCommand { get; set; }

        private readonly INavigationService _navigationService;

        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            ScanCommand = new DelegateCommand(() =>
            {
                _navigationService.NavigateAsync("ScanPage");
            });
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("Result"))
            {
                var fooReslut = parameters["Result"] as Result;
                BarcodeFormatType = fooReslut.BarcodeFormat.ToString();
                BarcodeResult = fooReslut.Text;

            }

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {

        }

    }

}
