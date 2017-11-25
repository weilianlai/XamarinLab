using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace XFAppFlow.ViewModels
{

    public class MainPageViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Acc { get; set; } = "";
        public string Password { get; set; } = "";
        public bool IsChecking { get; set; } = false;
        //public DelegateCommand LoginButtonCommand { get; set; }

        private readonly INavigationService _navigationService;


        public DelegateCommand LoginCommand { get; set; }


        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            LoginCommand = new DelegateCommand(async ()=> 
            {
                if (Acc == "123" && Password=="123" ) 
                {
                    IsChecking = true;
                    await Task.Delay(3000);
                    App.Current.Properties ["Acc"]=Acc;
                    App.Current.Properties["PW"] = Password;
                    await App.Current.SavePropertiesAsync();
                    IsChecking = false;
                    await _navigationService.NavigateAsync("xf:///MenuPage/NaviPage/MyPage");
                }
               
            }
            );

            //LoginButtonCommand = new DelegateCommand(() => 
            //{
            //    _navigationService.NavigateAsync("MyPage");

            //}
            //);

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
