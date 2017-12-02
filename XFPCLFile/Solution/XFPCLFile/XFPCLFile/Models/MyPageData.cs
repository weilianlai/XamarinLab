using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace XFPCLFile.Models
{
    public class MyPageData : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int Amt { get; set; }
        public bool IsMemory { get; set; }
    }
}
