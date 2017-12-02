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
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using XFRendCtrl.CustomControls;

[assembly: ExportRenderer(typeof(MyEntry), typeof(EntryRenderer))]

namespace XFRendCtrl.Droid.Renderers
{
    public class MyEntryRenderer: EntryRenderer
    {
        base.OnElementChanged(e);
            if (Control != null)
            {
                Control.SetBackgroundDrawable(null);
                Control.SetBackgroundColor(Android.Graphics.Color.SkyBlue);
            }
}
}