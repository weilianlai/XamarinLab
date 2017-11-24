using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using XFPageEvent.Events;

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
                _navigationService.NavigateAsync("NextPage");
            });

            _eventAggregator.GetEvent<EchoEvent>().Subscribe(x=> 
            {
                MyEntry = $"知道了：{x.Message}"; 
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
