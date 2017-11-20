using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XFDI.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public string  WhoareYou { get; set; }
        public MainPageViewModel(INavigationService navigationService) 
            : base (navigationService)
        {
            Title = "Main Page";
        }
    }
}
