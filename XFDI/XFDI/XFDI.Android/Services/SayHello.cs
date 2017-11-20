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

namespace XFDI.Droid.Services
{
    class SayHello: ISayHello
    {
        public string Hello()
        {
            return "I am Android";
        }

    }
}