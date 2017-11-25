using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace XFGrid.ViewModels
{

    public class MainPageViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly INavigationService _navigationService;
        public double CurrentFontSize { get; set; } = 20;

        public DelegateCommand LargeCommand { get; set; }

        public DelegateCommand SmallCommand { get; set; }



        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            LargeCommand = new DelegateCommand(()=> 
            {
                CurrentFontSize += 4;
            });
            SmallCommand = new DelegateCommand(()=> 
            {
                CurrentFontSize -= 4;
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
