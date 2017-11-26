using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using XFListView.Models;

namespace XFListView.ViewModels
{

    public class TaskDetailPageViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public MyTaskItem MyTaskItemSelected { get; set; } = new MyTaskItem();

        private readonly INavigationService _navigationService;

        public TaskDetailPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("Record"))
            {
                MyTaskItemSelected = parameters["Record"] as MyTaskItem;
            }
        }

    }

}
