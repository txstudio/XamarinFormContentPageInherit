# 在 Xamarin.Form 使用繼承 ContentPage 實作重複性功能

此範例程式碼透過繼承 ContentPage 的方式將 iOS 裝置預設上內距實作到自訂的 ContentPage 繼承類別

## 專案架構

此方案包含三個主要專案，說明如下

|專案名稱|描述|
|--|--|
|XamarinApp|Xamarin.Form 應用程式專案|
|XamarinApp.iOS|iOS 行動裝置專案|
|XamarinApp.Android|Android 行動裝置專案|

## Xamarin.Form 專案檔案說明

列出 XamarinApp 的 Xamarin.Form 專案下主要檔案與說明

|檔案名稱|描述|
|--|--|
|ProviderPage/PlatformDefaultPaddingPage.cs|繼承 ContentPage 的 iOS 預設上內距設定類別|
|MainPage.xaml|主要 XAML 由 &lt;ContentPage /&gt; 調整為 &lt;local:PlatformDefaultPaddingPage /&gt;|
|MainPage.xaml.cs|繼承類別從 ContentPage 變更為 PlatformDefaultPaddingPage|


## 參考資料

[contentpage inherit from custom basepage — Xamarin Forums](https://forums.xamarin.com/discussion/27265/contentpage-inherit-from-custom-basepage)

[How tu use the new Device.RuntimePlatform — Xamarin Forums](https://forums.xamarin.com/discussion/94651/how-tu-use-the-new-device-runtimeplatform)
