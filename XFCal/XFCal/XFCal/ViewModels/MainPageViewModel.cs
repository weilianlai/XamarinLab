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
        public string Result { get; set; } = "";
        public string Temp { get; set; } = "";
        public string aa { get; set; }
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
                Result += "1";
                aa = Result;
                Temp += aa;
            });
            
            TwoCommand = new DelegateCommand(() => 
            {
                Result += "2";
                aa = Result;
                Temp += aa;
            });
            ThreeCommand = new DelegateCommand(() => 
            {
                Result += "3";
                aa = Result;
            });
            FourCommand = new DelegateCommand(() => 
            {
                Result += "4";
                aa = Result;
            });
            FiveCommand = new DelegateCommand(() => 
            {
                Result += "5";
                aa = Result;
            });
            SixCommand = new DelegateCommand(() => 
            {
                Result += "6";
                aa = Result;
            });
            SevenCommand = new DelegateCommand(() =>
            {
                Result += "7";
                aa = Result;
            });
            EightCommand = new DelegateCommand(() => 
            {
                Result += "8";
                aa = Result;
            });
            NineCommand = new DelegateCommand(() => 
            {
                Result += "9";
                aa = Result;
            });
            ZeroCommand = new DelegateCommand(() => 
            {
                Result += "0";
                aa = Result;
            });
            DivideCommand = new DelegateCommand(() => 
            {
                Result = "";
                aa = "/";
            });
            MultipleCommand = new DelegateCommand(() => 
            {
                Result = "";
                aa = "*";
            });
            MinusCommand = new DelegateCommand(() => 
            {
                Result = "";
                aa = "-";
            });
            PlusCommand = new DelegateCommand(() => 
            {
                Result = "";
                aa = "+";
            });
            EqualCommand = new DelegateCommand(() => 
            {

                Result ="";
                aa = "";
                Temp = "";
            });
            ClearCommand = new DelegateCommand(()=> 
            {
                Result ="";
                aa = "";
                Temp="";
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
