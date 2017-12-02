using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XFDynaRes.Themes;

namespace XFDynaRes.Views
{
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();
		}

        public void btnDynamicRes_Clicked(object sender, EventArgs arg)
        {
            this.Resources["DynamicResourceColor"] = Color.Red;
            this.Resources["DynamicResourcefontSize"] = 12;
        }

        public void btnStaticObject_Clicked(object sender, EventArgs arg)
        {
            MyClass.StaticSize = 40;
            MyClass.StaticMember = Color.Orange;
        }

    }
}