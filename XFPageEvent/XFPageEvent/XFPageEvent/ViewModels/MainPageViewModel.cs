using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace XFPageEvent.ViewModels
{

    public class MainPageViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string MyEntry { get; set; }

        public DelegateCommand GoNextCommand { get; set; }

        private readonly INavigationService _navigationService;

        private readonly IEventAggregator _eventAggregator;

        public MainPageViewModel(INavigationService navigationService,
            IEventAggregator eventAggregator)
        {
            _navigationService = navigationService;

            _eventAggregator = eventAggregator;

            GoNextCommand = new DelegateCommand(()=> 
            {

            }
            );

            _eventAggregator.GetEvent

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
