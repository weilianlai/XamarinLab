using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XFStatRes.Themes
{
    public class MyClass
    {
        public static Color StaticMember { get; set; } = Color.Green;
        public static double StaticSize { get; set; } = 30;
        public static double StaticOpacity { get; set; } = 0.7;
    }
}
