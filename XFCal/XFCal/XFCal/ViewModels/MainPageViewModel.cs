using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace XFCal.ViewModels
{

    public class MainPageViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly INavigationService _navigationService;
        public int Result { get; set; }
        public DelegateCommand OneCommand { get; set; }
        public DelegateCommand TwoCommand { get; set; }
        public DelegateCommand ThreeCommand { get; set; }
        public DelegateCommand FourCommand { get; set; }
        public DelegateCommand FiveCommand { get; set; }
        public DelegateCommand SixCommand { get; set; }
        public DelegateCommand SevenCommand { get; set; }
        public DelegateCommand EightCommand { get; set; }
        public DelegateCommand NineCommand { get; set; }
        public DelegateCommand ZeroCommand { get; set; }
        public DelegateCommand DivideCommand { get; set; }
        public DelegateCommand MultipleCommand { get; set; }
        public DelegateCommand MinusCommand { get; set; }
        public DelegateCommand PlusCommand { get; set; }
        public DelegateCommand ClearCommand { get; set; }
        public DelegateCommand EqualCommand { get; set; }
        

        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            OneCommand = new DelegateCommand(() =>
            {
                Result = 1;
            });
            TwoCommand = new DelegateCommand(() => 
            {
                Result = 2;
            });
            ThreeCommand = new DelegateCommand(() => 
            {
                Result = 3;
            });
            FourCommand = new DelegateCommand(() => 
            {
                Result = 4;
            });
            FiveCommand = new DelegateCommand(() => 
            {
                Result = 5;
            });
            SixCommand = new DelegateCommand(() => 
            {
                Result = 6;
            });
            SevenCommand = new DelegateCommand(() =>
            {
                Result = 7;
            });
            EightCommand = new DelegateCommand(() => 
            {
                Result = 8;
            });
            NineCommand = new DelegateCommand(() => 
            {
                Result = 9;
            });
            ZeroCommand = new DelegateCommand(() => 
            {
                Result = 0;
            });
            DivideCommand = new DelegateCommand(() => { });
            MultipleCommand = new DelegateCommand(() => { });
            MinusCommand = new DelegateCommand(() => { });
            PlusCommand = new DelegateCommand(() => { });
            EqualCommand = new DelegateCommand(() => { });


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
