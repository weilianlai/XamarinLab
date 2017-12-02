using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XFAttProp.AttachedProperties
{
   public class EntryTypeAttached
    {
                #region EntryType 附加屬性 Attached Property
        public static readonly BindableProperty EntryTypeProperty =
               BindableProperty.CreateAttached(
                   propertyName: "EntryType",   // 屬性名稱 
                   returnType: typeof(string), // 回傳類型 
                   declaringType: typeof(Entry), // 宣告類型 
                   defaultValue: null, // 預設值 
                   propertyChanged: OnEntryTypeChanged  // 屬性值異動時，要執行的事件委派方法
               );

        public static void SetEntryType(BindableObject bindable, string entryType)
        {
            bindable.SetValue(EntryTypeProperty, entryType);
        }
        public static string GetEntryType(BindableObject bindable)
        {
            return (string)bindable.GetValue(EntryTypeProperty);
        }

        private static void OnEntryTypeChanged(BindableObject bindable, object oldValue, object newValue)
        {
            switch (foonewValue)
            {
                case "None":
                    break;
                case "email":
                    fooEntry.SetValue(Entry.PlaceholderProperty, "請輸入電子郵件");
                    fooEntry.Keyboard = Keyboard.Email;
                    fooEntry.FontSize = 20;
                    break;
                case "phone":
                    fooEntry.SetValue(Entry.PlaceholderProperty, "請輸入電話號碼");
                    fooEntry.Keyboard = Keyboard.Telephone;
                    fooEntry.FontSize = 16;
                    break;
                case "number":
                    fooEntry.SetValue(Entry.PlaceholderProperty, "請輸入數值");
                    fooEntry.Keyboard = Keyboard.Numeric;
                    fooEntry.FontSize = 24;
                    break;
                default:
                    break;
            }
            #endregion
        }
#endregion

    }
}
