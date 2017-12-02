using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace XFConvertBack.ViewModels
{

    public class MainPageViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public int YourAnswer { get; set; }
        private readonly INavigationService _navigationService;
        public readonly IPageDialogService _dialogService;
        public DelegateCommand GetAnswerCommand { get; set; }
        public DelegateCommand SetAnswerCommand { get; set; }

        public MainPageViewModel(INavigationService navigationService,
            IPageDialogService dialogService
            )
        {
            _navigationService = navigationService;
            _dialogService = dialogService;

            GetAnswerCommand = new DelegateCommand(async () =>
            {
                await _dialogService.DisplayAlertAsync("Info", YourAnswer.ToString(), "OK");
            });
            SetAnswerCommand = new DelegateCommand( () =>
            {
                YourAnswer=2;
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
