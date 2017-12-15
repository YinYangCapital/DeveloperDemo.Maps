using Xamarin.Forms;

namespace com.yinyangcapital.DeveloperDemo.Maps
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new com_yinyangcapital_DeveloperDemo_MapsPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
