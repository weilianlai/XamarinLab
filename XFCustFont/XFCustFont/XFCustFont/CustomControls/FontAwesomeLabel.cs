using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;


namespace XFCustFont.CustomControls
{
    public class FontAwesomeLabel : Label
    {
        public FontAwesomeLabel()
        {
            FontFamily = Device.OnPlatform("fontawesome", "fontawesome", "/Assets/Fonts/fontawesome.ttf#FontAwesome");
        }
    }
}
