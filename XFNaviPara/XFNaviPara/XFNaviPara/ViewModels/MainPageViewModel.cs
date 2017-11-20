using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace XFNaviPara.ViewModels
{

    public class MainPageViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string MyName { get; set; }
        public string MyAccount { get; set; }

        public DelegateCommand NextPageCommand { get; set; }

        private readonly INavigationService _navigationService;

        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NextPageCommand = new DelegateCommand(()=> 
            {
                NavigationParameters fooPara = new NavigationParameters();
                fooPara.Add(nameof(MyName), MyName);
                fooPara.Add(nameof(MyAccount), MyAccount);
                _navigationService.NavigateAsync("NextPage", fooPara);
            }
            );

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
