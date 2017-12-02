using PCLStorage;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using XFPCLFile.Models;

namespace XFPCLFile.ViewModels
{

    public class MainPageViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public MyPageData PageData { get; set; } = new MyPageData();
        public DelegateCommand SaveCommand { get; set; }
        public DelegateCommand LoadCommand { get; set; }
        private readonly INavigationService _navigationService;

        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            SaveCommand = new DelegateCommand(async () =>
            {

                IFolder fooFolder = await FileSystem.Current.LocalStorage.CreateFolderAsync("MyFolder", CreationCollisionOption.OpenIfExists);
                IFile file = await fooFolder.CreateFileAsync("PageData.dat", CreationCollisionOption.ReplaceExisting);
                await file.WriteAllTextAsync("42");

            });
            LoadCommand = new DelegateCommand(async () =>
            {
               
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
