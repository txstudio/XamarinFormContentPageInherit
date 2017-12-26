using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinApp
{
    /// <summary>
    /// 已設定 iOS 預設上內距離基底 ContentPage 物件
    /// </summary>
    public abstract class PlatformDefaultPaddingPage : ContentPage
    {
        private readonly double _default_padding_top = 20;

        protected PlatformDefaultPaddingPage()
        {
            this.SetIOSDefaultPadding();
        }

        /// <summary>
        /// 設定 iOS 裝置的預設 Padding 上內距離
        /// </summary>
        private void SetIOSDefaultPadding()
        {
            switch(Device.RuntimePlatform)
            {
                case Device.iOS:
                    this.Padding = new Thickness(0, _default_padding_top, 0, 0);
                    break;
                default:
                    break;
            }
        }
    }
}
