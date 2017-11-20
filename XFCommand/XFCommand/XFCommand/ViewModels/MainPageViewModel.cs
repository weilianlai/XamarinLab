using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace XFCommand.ViewModels
{

    public class MainPageViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly INavigationService _navigationService;

        public string MyLabel { get; set; }
        public DelegateCommand<string> ButtonCommand { get; set; }


        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            ButtonCommand = new DelegateCommand<string> (x =>
            {
                MyLabel = x;
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
