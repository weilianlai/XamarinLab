using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using XFDI.Interfaces;

namespace XFDI.ViewModels
{

    public class MainPageViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string WhoAreYou { get; set; }

        private readonly INavigationService _navigationService;
        ISayHello _SayHello;
        public MainPageViewModel(INavigationService navigationService, ISayHello sayHello)
        {
            _navigationService = navigationService;
            _SayHello = sayHello;
            WhoAreYou = _SayHello.Hello();
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
