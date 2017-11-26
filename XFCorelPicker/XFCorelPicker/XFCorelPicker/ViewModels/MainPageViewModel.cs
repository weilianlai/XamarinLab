using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace XFCorelPicker.ViewModels
{

    public class MainPageViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly INavigationService _navigationService;
        public string Lable1 { get; set; }
        public string Lable2 { get; set; }
        public string Picker1SelectedItem { get; set; }
        public string Picker2SelectedItem { get; set; }

        public ObservableCollection<string> Picker1Source { get; set; } = 
            new ObservableCollection<string>();
        public ObservableCollection<string> Picker2Source { get; set; } = 
            new ObservableCollection<string>();

        public DelegateCommand Picker1Command { get; set; }
        public DelegateCommand Picker2Command { get; set; }

        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            Picker1Source.Add( "A");
            Picker1Source.Add("B");
            Picker1Source.Add("C");
            Picker1Command = new DelegateCommand(()=> 
            {
                Lable1 = $"Picker1 = {Picker1SelectedItem}";
                Lable2 = "";
                Picker2Source.Clear();
                for (int i = 0; i < 20; i++)
                {
                    Picker2Source.Add($"{Picker1SelectedItem} {i}");
                }
            });

            Picker2Command = new DelegateCommand(()=> 
            {
                Lable2 = $"Picker2 = {Picker2SelectedItem}";
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
