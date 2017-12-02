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
using XFRendCtrl.Droid.Renderers;

[assembly: ExportRenderer(typeof(MyEntry), typeof(MyEntryRenderer))]
namespace XFRendCtrl.Droid.Renderers
{
    /// <summary>
    /// 這個類別，將會透過 EntryRenderer ，客製 Android 平台下的文字輸入盒
    /// </summary>
    public class MyEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.SetBackgroundDrawable(null);
                Control.SetBackgroundColor(Android.Graphics.Color.SkyBlue);
            }
        }
    }
}