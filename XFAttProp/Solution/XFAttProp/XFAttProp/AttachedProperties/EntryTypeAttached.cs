﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XFAttProp.AttachedProperties
{
    /// <summary>
    /// 建立一個類別，裡面使用 BindableProperty.CreateAttached 建立一個 XAML 用的附加屬性
    /// 在 XAML 中的用法     <Entry CustomAttached:EntryTypeAttached.EntryType="Email" />
    /// </summary>
    public class EntryTypeAttached
    {
        // 關於附加屬性，可以參考底下說明
        // https://developer.xamarin.com/guides/xamarin-forms/xaml/attached-properties/

        // 可以使用程式碼片段 vlAttachedProperty 快速產生要設計的程式碼
        #region EntryType 附加屬性 Attached Property
        /// <summary>
        /// 這個附加屬性，只能夠套用在 Entry 控制項上，會根據所指定的名稱，自動加上浮水印文字
        /// </summary>
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

        #endregion

        /// <summary>
        /// 當這個附加屬性值有變動的時候，需要執行的呼叫事件
        /// </summary>
        /// <param name="bindable"></param>
        /// <param name="oldValue"></param>
        /// <param name="newValue"></param>
        private static void OnEntryTypeChanged(BindableObject bindable, object oldValue, object newValue)
        {
            // 若所附加的屬性不是 Entry，則不要有任何處理動作
            var fooEntry = bindable as Entry;
            if (fooEntry == null)
                return;

            // 取得屬性值變動前與變動後的值
            var foooldValue = (oldValue as string)?.ToLower();
            var foonewValue = (newValue as string)?.ToLower();

            if (foonewValue == null)
            {
                return;
            }

            #region 根據指定附加屬性的值，設定所綁訂到的控制項(Entry)，的 Placeholder 屬性成為預設指定的文字
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
    }
}
