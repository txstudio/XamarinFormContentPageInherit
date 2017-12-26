using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp
{
    /*
     * 將預設繼承 ContentPage 修改為 PlatformDefaultPaddingPage
     * 
     * 並需要加工 MainPage.xaml 檔案的主要 XAML Element
     * 請參考 MainPage.xaml 註解內容
     */
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : PlatformDefaultPaddingPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
	}
}
