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
using XFDSDeviceID.Interfaces;
using XFDSDeviceID.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(GetDeviceID))]

namespace XFDSDeviceID.Droid
{
    public class GetDeviceID : IGetDeviceID
    {
        string IGetDeviceID.GetDeviceID()
        {
            return Android.OS.Build.Serial;
        }
    }
}