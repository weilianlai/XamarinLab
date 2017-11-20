using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace XFPrismMVVM.ViewModels
{

    public class MainPageViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly INavigationService _navigationService;

        public string Title { get; set; }
        public string MyEntry { get; set; }
        public string MyLabel { get; set; }
        public DelegateCommand MyButtonCommand { get; set; }


        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            MyButtonCommand = new DelegateCommand(() => 
            {
                MyLabel = MyEntry;
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
