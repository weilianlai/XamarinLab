using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using XFRendCtrl.CustomControls;
using XFRendCtrl.iOS.Renderers;

[assembly: ExportRenderer(typeof(MyEntry), typeof(MyEntryRenderer))]
namespace XFRendCtrl.iOS.Renderers
{
    /// <summary>
    /// 這個類別，將會透過 EntryRenderer ，客製 iOS 平台下的文字輸入盒
    /// </summary>
    public class MyEntryRenderer : EntryRenderer
    {
        protected override void
        OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.BorderStyle = UIKit.UITextBorderStyle.None;
            }
        }
    }
}