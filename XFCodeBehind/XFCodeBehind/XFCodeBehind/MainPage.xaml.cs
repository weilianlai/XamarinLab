using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFCodeBehind
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MyButton_Clicked(object sender, EventArgs e)
        {
            MyLabel.Text = "@@" + MyEntry.Text;
        }

        
    }
}
