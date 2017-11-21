using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using XFDI.Interfaces;
using XFDI.Droid.Services;

[assembly: Xamarin.Forms.Dependency(typeof(SayHello))]

namespace XFDI.Droid.Services
{
    public class SayHello : ISayHello
    {
        public string Hello()
        {
            //return "I am Android";
            return Android.OS.Build.Serial;
        }

    }
}