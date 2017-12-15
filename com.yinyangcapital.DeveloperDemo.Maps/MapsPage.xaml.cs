using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace com.yinyangcapital.DeveloperDemo.Maps
{
    /// <summary>
    ///     There should be no additional code required in this file in order to complete the demo
    /// </summary>
    public partial class com_yinyangcapital_DeveloperDemo_MapsPage : ContentPage
    {
        public com_yinyangcapital_DeveloperDemo_MapsPage()
        {
            InitializeComponent();

            //Set Safe Area for iOS
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }
    }
}
